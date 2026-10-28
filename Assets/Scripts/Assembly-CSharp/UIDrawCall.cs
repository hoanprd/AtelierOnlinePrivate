using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class UIDrawCall : MonoBehaviour
{
    [DoNotObfuscateNGUI]
    public enum Clipping
    {
        None = 0,
        TextureMask = 1,
        SoftClip = 3,
        ConstrainButDontClip = 4
    }

    public delegate void OnRenderCallback(Material mat);

    public delegate void OnCreateDrawCall(UIDrawCall dc, MeshFilter filter, MeshRenderer ren);

    [DoNotObfuscateNGUI]
    public enum ShadowMode
    {
        None = 0,
        Receive = 1,
        CastAndReceive = 2
    }

    private static BetterList<UIDrawCall> mActiveList = new BetterList<UIDrawCall>();

    private static BetterList<UIDrawCall> mInactiveList = new BetterList<UIDrawCall>();

    [NonSerialized]
    [HideInInspector]
    public int widgetCount;

    [NonSerialized]
    [HideInInspector]
    public int depthStart = int.MaxValue;

    [NonSerialized]
    [HideInInspector]
    public int depthEnd = int.MinValue;

    [NonSerialized]
    [HideInInspector]
    public UIPanel manager;

    [NonSerialized]
    [HideInInspector]
    public UIPanel panel;

    [NonSerialized]
    [HideInInspector]
    public Texture2D clipTexture;

    [NonSerialized]
    [HideInInspector]
    public bool alwaysOnScreen;

    [NonSerialized]
    [HideInInspector]
    public List<Vector3> verts = new List<Vector3>();

    [NonSerialized]
    [HideInInspector]
    public List<Vector3> norms = new List<Vector3>();

    [NonSerialized]
    [HideInInspector]
    public List<Vector4> tans = new List<Vector4>();

    [NonSerialized]
    [HideInInspector]
    public List<Vector2> uvs = new List<Vector2>();

    [NonSerialized]
    [HideInInspector]
    public List<Vector4> uv2 = new List<Vector4>();

    [NonSerialized]
    [HideInInspector]
    public List<Color> cols = new List<Color>();

    [NonSerialized]
    private Material mMaterial;

    [NonSerialized]
    private Texture mTexture;

    [NonSerialized]
    private Shader mShader;

    [NonSerialized]
    private int mClipCount;

    [NonSerialized]
    private Transform mTrans;

    [NonSerialized]
    private Mesh mMesh;

    [NonSerialized]
    private MeshFilter mFilter;

    [NonSerialized]
    private MeshRenderer mRenderer;

    [NonSerialized]
    private Material mDynamicMat;

    [NonSerialized]
    private int[] mIndices;

    [NonSerialized]
    private ShadowMode mShadowMode;

    [NonSerialized]
    private bool mRebuildMat = true;

    [NonSerialized]
    private bool mLegacyShader;

    [NonSerialized]
    private int mRenderQueue = 3000;

    [NonSerialized]
    private int mTriangles;

    [NonSerialized]
    public bool isDirty;

    [NonSerialized]
    private bool mTextureClip;

    [NonSerialized]
    private bool mIsNew = true;

    public OnRenderCallback onRender;

    public OnCreateDrawCall onCreateDrawCall;

    [NonSerialized]
    private string mSortingLayerName;

    [NonSerialized]
    private int mSortingOrder;

    private static ColorSpace mColorSpace = ColorSpace.Uninitialized;

    private const int maxIndexBufferCache = 10;

    private static List<int[]> mCache = new List<int[]>();

    protected MaterialPropertyBlock mBlock;

    private static int[] ClipRange = new int[]
    {
        Shader.PropertyToID("_ClipRange0"),
        Shader.PropertyToID("_ClipRange1"),
        Shader.PropertyToID("_ClipRange2"),
        Shader.PropertyToID("_ClipRange3")
    };

    private static int[] ClipArgs = new int[]
    {
        Shader.PropertyToID("_ClipArgs0"),
        Shader.PropertyToID("_ClipArgs1"),
        Shader.PropertyToID("_ClipArgs2"),
        Shader.PropertyToID("_ClipArgs3")
    };

    private static int dx9BugWorkaround = Shader.PropertyToID("_Dx9BugWorkaround");

    [Obsolete("Use UIDrawCall.activeList instead")]
    public static BetterList<UIDrawCall> list
    {
        get { return mActiveList; }
    }

    public static BetterList<UIDrawCall> activeList
    {
        get { return mActiveList; }
    }

    public static BetterList<UIDrawCall> inactiveList
    {
        get { return mInactiveList; }
    }

    public int renderQueue
    {
        get { return mRenderQueue; }
        set
        {
            if (mRenderQueue != value)
            {
                mRenderQueue = value;
                if (mDynamicMat != null) mDynamicMat.renderQueue = value;
            }
        }
    }

    public int sortingOrder
    {
        get { return mSortingOrder; }
        set
        {
            if (mSortingOrder != value)
            {
                mSortingOrder = value;
                if (mRenderer != null) mRenderer.sortingOrder = value;
            }
        }
    }

    public string sortingLayerName
    {
        get { return mSortingLayerName; }
        set
        {
            if (mSortingLayerName != value)
            {
                mSortingLayerName = value;
                if (mRenderer != null) mRenderer.sortingLayerName = value;
            }
        }
    }

    public int finalRenderQueue
    {
        get
        {
            if (mDynamicMat != null) return mDynamicMat.renderQueue;
            return (mMaterial != null) ? mMaterial.renderQueue : mRenderQueue;
        }
    }

    public Transform cachedTransform
    {
        get
        {
            if (mTrans == null) mTrans = transform;
            return mTrans;
        }
    }

    public Material baseMaterial
    {
        get { return mMaterial; }
        set
        {
            if (mMaterial != value)
            {
                mMaterial = value;
                mRebuildMat = true;
            }
        }
    }

    public Material dynamicMaterial
    {
        get { return mDynamicMat; }
    }

    public Texture mainTexture
    {
        get { return mTexture; }
        set
        {
            if (mTexture != value)
            {
                mTexture = value;
                if (mBlock == null) mBlock = new MaterialPropertyBlock();
                if (value != null) mBlock.SetTexture("_MainTex", value);
                if (mDynamicMat != null) mDynamicMat.mainTexture = value;
            }
        }
    }

    public Shader shader
    {
        get { return mShader; }
        set
        {
            if (mShader != value)
            {
                mShader = value;
                mRebuildMat = true;
            }
        }
    }

    public ShadowMode shadowMode
    {
        get { return mShadowMode; }
        set
        {
            if (mShadowMode != value)
            {
                mShadowMode = value;
                if (mRenderer != null)
                {
                    if (mShadowMode == ShadowMode.None)
                    {
                        mRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                        mRenderer.receiveShadows = false;
                    }
                    else if (mShadowMode == ShadowMode.Receive)
                    {
                        mRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                        mRenderer.receiveShadows = true;
                    }
                    else
                    {
                        mRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                        mRenderer.receiveShadows = true;
                    }
                }
            }
        }
    }

    public int triangles
    {
        get { return (mMesh != null) ? mTriangles : 0; }
    }

    public bool isClipped
    {
        get { return mClipCount != 0; }
    }

    private void CreateMaterial()
    {
        mTextureClip = false;
        mLegacyShader = false;
        mClipCount = (panel != null) ? panel.clipCount : 0;

        string shaderName = (mShader != null) ? mShader.name : ((mMaterial != null && mMaterial.shader != null) ? mMaterial.shader.name : "Unlit/Transparent Colored");
        shaderName = shaderName.Replace("GUI/Text Shader", "Unlit/Text");

        if (shaderName.Length > 2 && shaderName[shaderName.Length - 2] == ' ')
        {
            int idx = shaderName[shaderName.Length - 1];
            if (idx > '0' && idx <= '9') shaderName = shaderName.Substring(0, shaderName.Length - 2);
        }
        if (shaderName.StartsWith("Hidden/"))
            shaderName = shaderName.Substring(7);

        shaderName = shaderName.Replace(" (SoftClip)", "");
        shaderName = shaderName.Replace(" (TextureClip)", "");
        shaderName = shaderName.Replace(" [Clip]", "");

        if (panel != null && panel.clipping == UIPanel.Clipping.TextureMask)
        {
            mTextureClip = true;
            mShader = Shader.Find("Hidden/" + shaderName + " (TextureClip)");
            if (mShader == null) mShader = Shader.Find(shaderName + " (TextureClip)");
        }
        else if (mClipCount != 0)
        {
            mShader = Shader.Find("Hidden/" + shaderName + " " + mClipCount);
            if (mShader == null)
            {
                mShader = Shader.Find(shaderName + " " + mClipCount);
                if (mShader == null)
                {
                    mLegacyShader = true;
                    mShader = Shader.Find(shaderName + " (SoftClip)");
                }
            }
        }
        else
        {
            mShader = Shader.Find(shaderName);
        }

        if (mShader == null)
            mShader = Shader.Find("Unlit/Transparent Colored");

        if (mMaterial != null)
        {
            mDynamicMat = new Material(mMaterial);
            mDynamicMat.name = "[NGUI] " + mMaterial.name;
            mDynamicMat.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
            mDynamicMat.CopyPropertiesFromMaterial(mMaterial);
            string[] keywords = mMaterial.shaderKeywords;
            for (int i = 0; i < keywords.Length; i++)
                mDynamicMat.EnableKeyword(keywords[i]);

            if (mShader != null)
            {
                mDynamicMat.shader = mShader;
            }
            mDynamicMat.renderQueue = mRenderQueue;
            if (mTexture != null) mDynamicMat.mainTexture = mTexture;
        }
        else
        {
            mDynamicMat = new Material(mShader);
            mDynamicMat.name = "[NGUI] " + mShader.name;
            mDynamicMat.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
            mDynamicMat.renderQueue = mRenderQueue;
            if (mTexture != null) mDynamicMat.mainTexture = mTexture;
        }
    }

    private Material RebuildMaterial()
    {
        NGUITools.DestroyImmediate(mDynamicMat);
        CreateMaterial();
        mDynamicMat.renderQueue = mRenderQueue;
        if (mRenderer != null)
        {
            mRenderer.sharedMaterials = new Material[] { mDynamicMat };
            mRenderer.sortingLayerName = mSortingLayerName;
            mRenderer.sortingOrder = mSortingOrder;
        }
        return mDynamicMat;
    }

    private void UpdateMaterials()
    {
        if (panel == null) return;
        if (mRebuildMat || mDynamicMat == null || mClipCount != panel.clipCount || mTextureClip != (panel.clipping == UIPanel.Clipping.TextureMask))
        {
            RebuildMaterial();
            mRebuildMat = false;
        }
    }

    public void UpdateGeometry(int widgetCount, bool needsBounds)
    {
        this.widgetCount = widgetCount;
        int count = verts.Count;

        if (count > 0 && (count == uvs.Count && count == cols.Count) && (count % 4) == 0)
        {
            if (mFilter == null) mFilter = gameObject.GetComponent<MeshFilter>();
            if (mFilter == null) mFilter = gameObject.AddComponent<MeshFilter>();

            if (count < 65000)
            {
                int indexCount = (count >> 1) * 3;
                bool setIndices = (mIndices == null || mIndices.Length != indexCount);

                if (mMesh == null)
                {
                    mMesh = new Mesh();
                    mMesh.hideFlags = HideFlags.DontSave;
                    mMesh.name = (mMaterial != null) ? "[NGUI] " + mMaterial.name : "[NGUI] Mesh";
                    mMesh.MarkDynamic();
                    setIndices = true;
                }

                bool trim = uvs.Count != count || cols.Count != count || uv2.Count != count || norms.Count != count || tans.Count != count;
                if (!trim && mMesh.vertexCount != count)
                {
                    mMesh.Clear();
                    setIndices = true;
                }

                mMesh.SetVertices(verts);
                mMesh.SetUVs(0, uvs);
                mMesh.SetColors(cols);
                mMesh.SetUVs(1, (uv2.Count == count) ? uv2 : null);
                mMesh.SetNormals((norms.Count == count) ? norms : null);
                mMesh.SetTangents((tans.Count == count) ? tans : null);

                if (setIndices)
                {
                    mIndices = GenerateCachedIndexBuffer(count, indexCount);
                    mMesh.SetTriangles(mIndices, 0, needsBounds);
                }

                if (needsBounds && !alwaysOnScreen)
                    mMesh.RecalculateBounds();

                mFilter.mesh = mMesh;
            }
            else
            {
                mTriangles = 0;
                if (mMesh != null) mMesh.Clear();
            }

            if (mRenderer == null) mRenderer = gameObject.GetComponent<MeshRenderer>();
            if (mRenderer == null)
            {
                mRenderer = gameObject.AddComponent<MeshRenderer>();
                if (mShadowMode == ShadowMode.None)
                {
                    mRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                    mRenderer.receiveShadows = false;
                }
            }

            if (mIsNew)
            {
                mIsNew = false;
                if (onCreateDrawCall != null)
                    onCreateDrawCall(this, mFilter, mRenderer);
            }

            UpdateMaterials();
        }
        else
        {
            if (mFilter != null && mFilter.mesh != null) mFilter.mesh.Clear();
        }

        verts.Clear();
        uvs.Clear();
        uv2.Clear();
        cols.Clear();
        norms.Clear();
        tans.Clear();
    }

    private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
    {
        for (int i = 0, imax = mCache.Count; i < imax; ++i)
        {
            int[] ids = mCache[i];
            if (ids != null && ids.Length == indexCount)
                return ids;
        }

        int[] rv = new int[indexCount];
        int index = 0;
        for (int i = 0; i < vertexCount; i += 4)
        {
            rv[index++] = i;
            rv[index++] = i + 1;
            rv[index++] = i + 2;

            rv[index++] = i + 2;
            rv[index++] = i + 3;
            rv[index++] = i;
        }

        if (mCache.Count > maxIndexBufferCache) mCache.RemoveAt(0);
        mCache.Add(rv);
        return rv;
    }

    private void OnWillRenderObject()
    {
        UpdateMaterials();

        if (mBlock != null && mRenderer != null)
            mRenderer.SetPropertyBlock(mBlock);

        if (onRender != null)
            onRender(mDynamicMat != null ? mDynamicMat : mMaterial);

        if (mDynamicMat == null || mClipCount == 0) return;

        if (mTextureClip)
        {
            Vector4 cr = panel.drawCallClipRange;
            Vector2 soft = panel.clipSoftness;
            Vector2 sharpness = new Vector2(1000f, 1000f);
            if (soft.x > 0f) sharpness.x = cr.z / soft.x;
            if (soft.y > 0f) sharpness.y = cr.w / soft.y;

            mDynamicMat.SetVector(ClipRange[0], new Vector4(-cr.x / cr.z, -cr.y / cr.w, 1f / cr.z, 1f / cr.w));
            mDynamicMat.SetTexture("_ClipTex", clipTexture);
        }
        else if (!mLegacyShader)
        {
            UIPanel currentPanel = panel;
            for (int i = 0; currentPanel != null;)
            {
                if (currentPanel.hasClipping)
                {
                    float angle = 0f;
                    Vector4 cr = currentPanel.drawCallClipRange;
                    if (currentPanel != panel)
                    {
                        Vector3 pos = currentPanel.cachedTransform.InverseTransformPoint(panel.cachedTransform.position);
                        cr.x -= pos.x;
                        cr.y -= pos.y;

                        Vector3 v0 = panel.cachedTransform.rotation.eulerAngles;
                        Vector3 v1 = currentPanel.cachedTransform.rotation.eulerAngles;
                        Vector3 diff = v1 - v0;
                        diff.x = NGUIMath.WrapAngle(diff.x);
                        diff.y = NGUIMath.WrapAngle(diff.y);
                        diff.z = NGUIMath.WrapAngle(diff.z);
                        angle = diff.z;
                    }
                    SetClipping(i++, cr, currentPanel.clipSoftness, angle);
                    if (i >= ClipRange.Length) break;
                }
                currentPanel = currentPanel.parentPanel;
            }
        }
    }

    private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
    {
        angle *= -Mathf.Deg2Rad;
        Vector2 sharpness = new Vector2(1000f, 1000f);
        if (soft.x > 0f) sharpness.x = cr.z / soft.x;
        if (soft.y > 0f) sharpness.y = cr.w / soft.y;

        if (index < ClipRange.Length)
        {
            mDynamicMat.SetVector(ClipRange[index], new Vector4(-cr.x / cr.z, -cr.y / cr.w, 1f / cr.z, 1f / cr.w));
            mDynamicMat.SetVector(ClipArgs[index], new Vector4(sharpness.x, sharpness.y, Mathf.Sin(angle), Mathf.Cos(angle)));
        }
    }

    private void Awake()
    {
        mTrans = transform;
    }

    private void OnEnable()
    {
        mRebuildMat = true;
    }

    private void OnDisable()
    {
        depthStart = int.MaxValue;
        depthEnd = int.MinValue;
        panel = null;
        manager = null;
        mMaterial = null;
        mTexture = null;
        clipTexture = null;

        if (mRenderer != null)
            mRenderer.sharedMaterials = new Material[] { };

        NGUITools.DestroyImmediate(mDynamicMat);
        mDynamicMat = null;
    }

    private void OnDestroy()
    {
        NGUITools.DestroyImmediate(mMesh);
        mMesh = null;
    }

    public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
    {
        return Create(null, panel, mat, tex, shader);
    }

    private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
    {
        UIDrawCall dc = Create(name);
        dc.gameObject.layer = pan.cachedGameObject.layer;
        dc.baseMaterial = mat;
        dc.mainTexture = tex;
        dc.shader = shader;
        dc.renderQueue = pan.startingRenderQueue;
        dc.sortingOrder = pan.sortingOrder;
        dc.manager = pan;
        dc.panel = pan;
        if (pan.cachedTransform != null)
        {
            dc.cachedTransform.SetParent(pan.cachedTransform, false);
            dc.cachedTransform.localPosition = Vector3.zero;
            dc.cachedTransform.localRotation = Quaternion.identity;
            dc.cachedTransform.localScale = Vector3.one;
        }
        return dc;
    }

    private static UIDrawCall Create(string name)
    {
        while (mInactiveList.size > 0)
        {
            UIDrawCall dc = mInactiveList.Pop();
            if (dc != null)
            {
                mActiveList.Add(dc);
                if (name != null) dc.name = name;
                NGUITools.SetActive(dc.gameObject, true);
                return dc;
            }
        }

        GameObject go = new GameObject(name != null ? name : "_UIDrawCall");
        go.hideFlags = HideFlags.DontSave;
        UIDrawCall newDC = go.AddComponent<UIDrawCall>();
        mActiveList.Add(newDC);
        return newDC;
    }

    public static void ClearAll()
    {
        bool playing = Application.isPlaying;
        for (int i = mActiveList.size; i > 0;)
        {
            UIDrawCall dc = mActiveList.buffer[--i];
            if (dc != null)
            {
                if (playing) NGUITools.SetActive(dc.gameObject, false);
                else NGUITools.DestroyImmediate(dc.gameObject);
            }
        }
        mActiveList.Clear();
    }

    public static void ReleaseAll()
    {
        ClearAll();
        ReleaseInactive();
    }

    public static void ReleaseInactive()
    {
        for (int i = mInactiveList.size; i > 0;)
        {
            UIDrawCall dc = mInactiveList.buffer[--i];
            if (dc != null) NGUITools.DestroyImmediate(dc.gameObject);
        }
        mInactiveList.Clear();
    }

    public static int Count(UIPanel panel)
    {
        int count = 0;
        for (int i = 0; i < mActiveList.size; ++i)
            if (mActiveList.buffer[i].manager == panel) ++count;
        return count;
    }

    public static void Destroy(UIDrawCall dc)
    {
        if (dc != null)
        {
            dc.onRender = null;
            if (Application.isPlaying)
            {
                if (mActiveList.Remove(dc))
                {
                    if (dc.cachedTransform != null)
                        dc.cachedTransform.SetParent(null, false);
                    NGUITools.SetActive(dc.gameObject, false);
                    mInactiveList.Add(dc);
                    dc.mIsNew = true;
                }
            }
            else
            {
                mActiveList.Remove(dc);
                NGUITools.DestroyImmediate(dc.gameObject);
            }
        }
    }

    public static void MoveToScene(Scene scene)
    {
        foreach (UIDrawCall dc in activeList)
        {
            if (dc != null && dc.transform.parent == null)
                SceneManager.MoveGameObjectToScene(dc.gameObject, scene);
        }
        foreach (UIDrawCall dc in inactiveList)
        {
            if (dc != null && dc.transform.parent == null)
                SceneManager.MoveGameObjectToScene(dc.gameObject, scene);
        }
    }
}
