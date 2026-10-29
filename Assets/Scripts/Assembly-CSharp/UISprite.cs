using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UISprite : UIBasicSprite
{
    [HideInInspector]
    [SerializeField]
    private UnityEngine.Object mAtlas;

    [HideInInspector]
    [SerializeField]
    private string mSpriteName;

    [HideInInspector]
    [SerializeField]
    private bool mFixedAspect;

    [HideInInspector]
    [SerializeField]
    private bool mFillCenter = true;

    [NonSerialized]
    protected UISpriteData mSprite;

    [NonSerialized]
    private bool mSpriteSet;

    public override Texture mainTexture
    {
        get
        {
            UIAtlas uiatlas = mAtlas as UIAtlas;
            if (uiatlas != null)
            {
                return uiatlas.texture;
            }
            return base.mainTexture;
        }
        set
        {
            base.mainTexture = value;
        }
    }

    public override Material material
    {
        get
        {
            UIAtlas uiatlas = mAtlas as UIAtlas;
            if (uiatlas != null)
            {
                return uiatlas.spriteMaterial;
            }
            return base.material;
        }
        set
        {
            base.material = value;
        }
    }

    public INGUIAtlas atlas
    {
        get
        {
            if (!mSpriteSet)
            {
                mSpriteSet = true;
                Transform tr = cachedTransform;
                if (mAtlas == null)
                {
                    UIAtlasFindAtlas(tr);
                }
            }
            return mAtlas as INGUIAtlas;
        }
        set
        {
            if (mAtlas as UnityEngine.Object == value as UnityEngine.Object)
            {
                return;
            }
            mAtlas = value as UnityEngine.Object;
            mSpriteSets();
            mSprite = null;
            mSpriteSet = true;
            MarkAsChanged();
        }
    }

    public bool fixedAspect
    {
        get
        {
            return mFixedAspect;
        }
        set
        {
            if (mFixedAspect != value)
            {
                mFixedAspect = value;
                MarkAsChanged();
            }
        }
    }

    public string spriteName
    {
        get
        {
            return mSpriteName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                if (!string.IsNullOrEmpty(mSpriteName))
                {
                    mSpriteName = string.Empty;
                    mSprite = null;
                    MarkAsChanged();
                }
            }
            else if (mSpriteName != value)
            {
                mSpriteName = value;
                mSprite = null;
                MarkAsChanged();
            }
        }
    }

    public new bool isValid
    {
        get
        {
            return GetAtlasSprite() != null;
        }
    }

    [Obsolete]
    public bool fillCenter
    {
        get
        {
            return mFillCenter;
        }
        set
        {
            if (mFillCenter != value)
            {
                mFillCenter = value;
                MarkAsChanged();
            }
        }
    }

    public bool applyGradient { get; set; }

    public Color gradientTop { get; set; } = Color.white;

    public Color gradientBottom { get; set; } = Color.white;

    public override Vector4 border
    {
        get
        {
            if (mSprite != null)
            {
                return new Vector4(mSprite.borderLeft, mSprite.borderBottom, mSprite.borderRight, mSprite.borderTop);
            }
            return base.border;
        }
    }

    protected override Vector4 padding
    {
        get
        {
            if (mSprite != null)
            {
                return new Vector4(mSprite.paddingLeft, mSprite.paddingBottom, mSprite.paddingRight, mSprite.paddingTop);
            }
            return base.padding;
        }
    }

    public override float pixelSize
    {
        get
        {
            UIAtlas uiatlas = mAtlas as UIAtlas;
            if (uiatlas != null)
            {
                return uiatlas.pixelSize;
            }
            return 1f;
        }
    }

    public override int minWidth
    {
        get
        {
            if (mSprite == null)
            {
                return base.minWidth;
            }
            int num = mSprite.borderLeft + mSprite.borderRight;
            if (mSprite.width < num)
            {
                num = mSprite.width;
            }
            return Mathf.Max(2, num);
        }
    }

    public override int minHeight
    {
        get
        {
            if (mSprite == null)
            {
                return base.minHeight;
            }
            int num = mSprite.borderTop + mSprite.borderBottom;
            if (mSprite.height < num)
            {
                num = mSprite.height;
            }
            return Mathf.Max(2, num);
        }
    }

    public override Vector4 drawingDimensions
    {
        get
        {
            Vector4 vector = base.drawingDimensions;
            if (mSprite != null && mSprite.hasPadding)
            {
                float num = pixelSize;
                if (num != 0f)
                {
                    vector.x += (float)mSprite.paddingLeft * num;
                    vector.y += (float)mSprite.paddingBottom * num;
                    vector.z -= (float)mSprite.paddingRight * num;
                    vector.w -= (float)mSprite.paddingTop * num;
                }
            }
            return vector;
        }
    }

    public override bool premultipliedAlpha
    {
        get
        {
            Material mat = material;
            return mat != null && mat.shader != null && mat.shader.name.Contains("Premultiplied");
        }
    }

    public UISpriteData GetSprite(string name)
    {
        INGUIAtlas inguiAtlas = atlas;
        if (inguiAtlas != null)
        {
            return inguiAtlas.GetSprite(name);
        }
        return null;
    }

    public override void MarkAsChanged()
    {
        mSprite = null;
        base.MarkAsChanged();
    }

    public UISpriteData GetAtlasSprite()
    {
        if (!mSpriteSet)
        {
            atlas = (mAtlas as INGUIAtlas);
        }
        if (mSprite == null)
        {
            if (!string.IsNullOrEmpty(mSpriteName))
            {
                INGUIAtlas inguiAtlas = atlas;
                if (inguiAtlas != null)
                {
                    mSprite = inguiAtlas.GetSprite(mSpriteName);
                }
            }
        }
        return mSprite;
    }

    protected void SetAtlasSprite(UISpriteData sp)
    {
        if (sp != null)
        {
            mSpriteName = sp.name;
            mSprite = sp;
            mSpriteSet = true;
        }
        else
        {
            mSpriteName = ((sp != null) ? sp.name : string.Empty);
            mSprite = sp;
        }
    }

    public override void MakePixelPerfect()
    {
        base.MakePixelPerfect();
        UISpriteData atlasSprite = GetAtlasSprite();
        if (atlasSprite == null)
        {
            return;
        }
        Vector3 scale = cachedTransform.localScale;
        if (atlasSprite.width > 0 && atlasSprite.height > 0)
        {
            width = atlasSprite.width;
            height = atlasSprite.height;
        }
    }

    protected override void OnInit()
    {
        mSpriteSet = false;
        if (mAtlas == null)
        {
            UIAtlasFindAtlas(cachedTransform);
        }
        base.OnInit();
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();
        if (!mSpriteSet)
        {
            if (mAtlas == null)
            {
                UIAtlasFindAtlas(cachedTransform);
            }
            else
            {
                mSpriteSet = true;
            }
        }
    }

    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        Texture tex = mainTexture;
        if (tex == null)
        {
            return;
        }
        if (mSprite == null)
        {
            mSprite = GetAtlasSprite();
        }
        if (mSprite == null)
        {
            return;
        }

        Rect outer = new Rect(mSprite.x, mSprite.y, mSprite.width, mSprite.height);
        Rect inner = new Rect(mSprite.x + mSprite.borderLeft, mSprite.y + mSprite.borderTop,
            mSprite.width - mSprite.borderLeft - mSprite.borderRight,
            mSprite.height - mSprite.borderBottom - mSprite.borderTop);

        outer = NGUIMath.ConvertToTexCoords(outer, tex.width, tex.height);
        inner = NGUIMath.ConvertToTexCoords(inner, tex.width, tex.height);

        int count = verts.Count;
        Fill(verts, uvs, cols, outer, inner);
        if (onPostFill != null)
        {
            onPostFill(this, count, verts, uvs, cols);
        }
    }

    private void UIAtlasFindAtlas(Transform tr)
    {
        while (tr != null)
        {
            UIAtlas comp = tr.GetComponent<UIAtlas>();
            if (comp != null)
            {
                mAtlas = comp;
                mSpriteSet = true;
                break;
            }
            tr = tr.parent;
        }
    }

    private void mSpriteSets()
    {
        mSpriteSet = true;
    }
}