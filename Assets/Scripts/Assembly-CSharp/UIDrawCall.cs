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
    public int depthStart;

    [NonSerialized]
    [HideInInspector]
    public int depthEnd;

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
    private bool mRebuildMat;

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
                if (mMaterial != null) mMaterial.renderQueue = value;
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
                mRebuildMat = true;
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
                mRebuildMat = true;
            }
        }
    }

    public int triangles
    {
        get { return mTriangles; }
    }

    public bool isClipped
    {
        get { return mClipCount > 0; }
    }

    private void CreateMaterial()
    {
        mClipCount = 0;
        mTextureClip = false;

        Shader s = mShader;
        if (s == null && mMaterial != null) s = mMaterial.shader;

        if (panel != null)
        {
            mClipCount = panel.clipCount;
            mTextureClip = (panel.clipping == UIPanel.Clipping.TextureMask);
        }

        string shaderName = (s != null) ? s.name : "Unlit/Transparent Colored";

        if (mClipCount > 0)
        {
            if (mTextureClip)
            {
                shaderName = shaderName.Replace(" (SoftClip)", "");
                shaderName = shaderName.Replace(" [Clip]", "");
                shaderName += " (TextureClip)";
            }
            else
            {
                shaderName = shaderName.Replace(" (TextureClip)", "");
                shaderName = shaderName.Replace(" [Clip]", "");
                shaderName += " (SoftClip)";
            }
        }
        else
        {
            shaderName = shaderName.Replace(" (SoftClip)", "");
            shaderName = shaderName.Replace(" (TextureClip)", "");
        }

        Shader shaderToUse = Shader.Find(shaderName);
        if (shaderToUse == null && s != null) shaderToUse = s;

        if (mMaterial != null)
        {
            if (shaderToUse != null && shaderToUse != mMaterial.shader)
            {
                if (mDynamicMat != null)
                {
                    NGUITools.Destroy(mDynamicMat);
                    mDynamicMat = null;
                }
                mDynamicMat = new Material(mMaterial);
                mDynamicMat.name = "[NGUI] Dynamic - " + mMaterial.name;
                mDynamicMat.shader = shaderToUse;
                mDynamicMat.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
                mDynamicMat.renderQueue = mRenderQueue;
                mRenderer.sharedMaterials = new Material[] { mDynamicMat };
                return;
            }
        }

        if (mDynamicMat != null)
        {
            NGUITools.Destroy(mDynamicMat);
            mDynamicMat = null;
        }

        if (mMaterial != null)
        {
            mMaterial.renderQueue = mRenderQueue;
            mRenderer.sharedMaterials = new Material[] { mMaterial };
        }
        else if (shaderToUse != null)
        {
            if (mDynamicMat == null)
            {
                mDynamicMat = new Material(shaderToUse);
                mDynamicMat.name = "[NGUI] 3rdParty - " + shaderToUse.name;
                mDynamicMat.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
                mDynamicMat.renderQueue = mRenderQueue;
            }
            mDynamicMat.shader = shaderToUse;
            if (mTexture != null) mDynamicMat.mainTexture = mTexture;
            mRenderer.sharedMaterials = new Material[] { mDynamicMat };
        }
        else
        {
            mRenderer.sharedMaterials = new Material[0];
        }
    }

    private Material RebuildMaterial()
    {
        CreateMaterial();
        return mDynamicMat != null ? mDynamicMat : mMaterial;
    }

    public void UpdateMaterials()
    {
        if (mMaterial == null && mDynamicMat == null)
        {
            CreateMaterial();
        }
        else if (panel != null)
        {
            int clipCount = panel.clipCount;
            if (mClipCount != clipCount || mRebuildMat)
            {
                mRebuildMat = false;
                CreateMaterial();
            }
        }
    }

    public void UpdateGeometry(int widgetCount, bool needsBounds)
    {
        this.widgetCount = widgetCount;

        if (verts.Count == 0)
        {
            if (mMesh != null)
            {
                mMesh.Clear();
                mTriangles = 0;
            }
            return;
        }

        if (mMesh == null)
        {
            mMesh = new Mesh();
            mMesh.hideFlags = HideFlags.DontSave;
        }

        if (mFilter == null) mFilter = GetComponent<MeshFilter>();
        if (mFilter == null) mFilter = gameObject.AddComponent<MeshFilter>();

        if (mRenderer == null) mRenderer = GetComponent<MeshRenderer>();
        if (mRenderer == null) mRenderer = gameObject.AddComponent<MeshRenderer>();

        mMesh.SetVertices(verts);
        mMesh.SetUVs(0, uvs);
        if (uv2.Count > 0) mMesh.SetUVs(1, uv2);
        mMesh.SetColors(cols);
        if (norms.Count > 0) mMesh.SetNormals(norms);
        if (tans.Count > 0) mMesh.SetTangents(tans);

        int vertexCount = verts.Count;
        int indexCount = (vertexCount >> 1) * 3;

        if (mIndices == null || mIndices.Length != indexCount)
        {
            mIndices = GenerateCachedIndexBuffer(vertexCount, indexCount);
        }

        mMesh.triangles = mIndices;

        if (needsBounds)
        {
            mMesh.RecalculateBounds();
        }

        mFilter.mesh = mMesh;
        mTriangles = mMesh.triangles.Length >> 1;

        if (mIsNew)
        {
            mIsNew = false;
            if (onCreateDrawCall != null)
                onCreateDrawCall(this, mFilter, mRenderer);
        }
    }

    private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
    {
        for (int i = 0, imax = mCache.Count; i < imax; ++i)
        {
            int[] cache = mCache[i];
            if (cache.Length == indexCount)
                return cache;
        }

        int[] indices = new int[indexCount];
        for (int i = 0, v = 0; i < indexCount; i += 6, v += 4)
        {
            indices[i] = v;
            indices[i + 1] = v + 1;
            indices[i + 2] = v + 2;

            indices[i + 3] = v + 2;
            indices[i + 4] = v + 3;
            indices[i + 5] = v;
        }

        if (mCache.Count < maxIndexBufferCache)
        {
            mCache.Add(indices);
        }
        return indices;
    }

    private void OnWillRenderObject()
    {
        UpdateMaterials();

        if (mBlock != null && mRenderer != null)
        {
            mRenderer.SetPropertyBlock(mBlock);
        }

        if (onRender != null)
        {
            Material mat = (mDynamicMat != null) ? mDynamicMat : mMaterial;
            onRender(mat);
        }

        if (mClipCount != 0 && panel != null)
        {
            Material mat = (mDynamicMat != null) ? mDynamicMat : mMaterial;
            if (mat != null)
            {
                UIPanel p = panel;
                int index = 0;
                while (p != null)
                {
                    if (p.hasClipping)
                    {
                        Vector4 cr = p.drawCallClipRange;
                        mat.SetVector(ClipRange[index], cr);
                        Vector2 soft = p.clipSoftness;
                        mat.SetVector(ClipArgs[index], new Vector4(1f / soft.x, 1f / soft.y, p.alpha, 0f));
                        ++index;
                        if (index >= ClipRange.Length) break;
                    }
                    p = p.parentPanel;
                }
            }
        }
    }

    private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
    {
    }

    private void Awake()
    {
        mTrans = transform;
    }

    private void OnEnable()
    {
        mIsNew = true;
    }

    private void OnDisable()
    {
        baseMaterial = null;
        mainTexture = null;
        shader = null;

        if (mRenderer != null) mRenderer.sharedMaterials = new Material[0];
        if (mDynamicMat != null)
        {
            NGUITools.Destroy(mDynamicMat);
            mDynamicMat = null;
        }
        mMaterial = null;
    }

    private void OnDestroy()
    {
        if (mMesh != null)
        {
            NGUITools.Destroy(mMesh);
            mMesh = null;
        }
    }

    public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
    {
        return Create(panel != null ? panel.name + " DrawCall" : "DrawCall", panel, mat, tex, shader);
    }

    private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
    {
        GameObject go = null;
        UIDrawCall dc = null;

        if (mInactiveList.size > 0)
        {
            int last = mInactiveList.size - 1;
            dc = mInactiveList.buffer[last];
            mInactiveList.RemoveAt(last);
            go = dc.gameObject;
            go.SetActive(true);
        }
        else
        {
            go = new GameObject(name);
            go.hideFlags = HideFlags.DontSave;
            dc = go.AddComponent<UIDrawCall>();
        }

        dc.panel = pan;
        dc.baseMaterial = mat;
        dc.mainTexture = tex;
        dc.shader = shader;
        dc.mRenderQueue = pan.startingRenderQueue;
        dc.mSortingLayerName = pan.sortingLayerName;
        dc.mSortingOrder = pan.sortingOrder;
        dc.UpdateMaterials();

        mActiveList.Add(dc);
        return dc;
    }

    public static void ClearAll()
    {
        for (int i = mActiveList.size; i > 0;)
        {
            UIDrawCall dc = mActiveList.buffer[--i];
            if (dc != null) Destroy(dc);
        }
        mActiveList.Clear();

        for (int i = mInactiveList.size; i > 0;)
        {
            UIDrawCall dc = mInactiveList.buffer[--i];
            if (dc != null && dc.gameObject != null)
            {
                NGUITools.Destroy(dc.gameObject);
            }
        }
        mInactiveList.Clear();
    }

    public static void ReleaseAll()
    {
        ClearAll();
    }

    public static void ReleaseInactive()
    {
        for (int i = mInactiveList.size; i > 0;)
        {
            UIDrawCall dc = mInactiveList.buffer[--i];
            if (dc != null && dc.gameObject != null)
            {
                NGUITools.Destroy(dc.gameObject);
            }
        }
        mInactiveList.Clear();
    }

    public static int Count(UIPanel panel)
    {
        int count = 0;
        for (int i = 0; i < mActiveList.size; ++i)
        {
            if (mActiveList.buffer[i].panel == panel) ++count;
        }
        return count;
    }

    public static void Destroy(UIDrawCall dc)
    {
        if (dc != null)
        {
            dc.gameObject.SetActive(false);
            mActiveList.Remove(dc);
            if (!mInactiveList.Contains(dc))
            {
                mInactiveList.Add(dc);
            }
        }
    }

    public static void MoveToScene(Scene scene)
    {
        for (int i = 0; i < mActiveList.size; ++i)
        {
            SceneManager.MoveGameObjectToScene(mActiveList.buffer[i].gameObject, scene);
        }
        for (int i = 0; i < mInactiveList.size; ++i)
        {
            SceneManager.MoveGameObjectToScene(mInactiveList.buffer[i].gameObject, scene);
        }
    }
}