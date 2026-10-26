using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class UIBasicSprite : UIWidget
{
    [DoNotObfuscateNGUI]
    public enum Type
    {
        Simple = 0,
        Sliced = 1,
        Tiled = 2,
        Filled = 3,
        Advanced = 4
    }

    [DoNotObfuscateNGUI]
    public enum FillDirection
    {
        Horizontal = 0,
        Vertical = 1,
        Radial90 = 2,
        Radial180 = 3,
        Radial360 = 4
    }

    [DoNotObfuscateNGUI]
    public enum AdvancedType
    {
        Invisible = 0,
        Sliced = 1,
        Tiled = 2
    }

    [DoNotObfuscateNGUI]
    public enum Flip
    {
        Nothing = 0,
        Horizontally = 1,
        Vertically = 2,
        Both = 3
    }

    [HideInInspector]
    [SerializeField]
    protected Type mType = Type.Simple;

    [HideInInspector]
    [SerializeField]
    protected FillDirection mFillDirection = FillDirection.Radial360;

    [HideInInspector]
    [SerializeField]
    protected float mFillAmount = 1f;

    [HideInInspector]
    [SerializeField]
    protected bool mInvert = false;

    [HideInInspector]
    [SerializeField]
    protected Flip mFlip = Flip.Nothing;

    [HideInInspector]
    [SerializeField]
    protected bool mApplyGradient = false;

    [HideInInspector]
    [SerializeField]
    protected Color mGradientTop = Color.white;

    [HideInInspector]
    [SerializeField]
    protected Color mGradientBottom = Color.white;

    [NonSerialized]
    protected Rect mInnerUV;

    [NonSerialized]
    protected Rect mOuterUV;

    public AdvancedType centerType = AdvancedType.Sliced;

    public AdvancedType leftType = AdvancedType.Sliced;

    public AdvancedType rightType = AdvancedType.Sliced;

    public AdvancedType bottomType = AdvancedType.Sliced;

    public AdvancedType topType = AdvancedType.Sliced;

    protected static Vector2[] mTempPos = new Vector2[4];

    protected static Vector2[] mTempUVs = new Vector2[4];

    public virtual Type type
    {
        get
        {
            return mType;
        }
        set
        {
            if (mType != value)
            {
                mType = value;
                MarkAsChanged();
            }
        }
    }

    public Flip flip
    {
        get
        {
            return mFlip;
        }
        set
        {
            if (mFlip != value)
            {
                mFlip = value;
                MarkAsChanged();
            }
        }
    }

    public FillDirection fillDirection
    {
        get
        {
            return mFillDirection;
        }
        set
        {
            if (mFillDirection != value)
            {
                mFillDirection = value;
                MarkAsChanged();
            }
        }
    }

    public float fillAmount
    {
        get
        {
            return mFillAmount;
        }
        set
        {
            float clamped = Mathf.Clamp01(value);
            if (mFillAmount != clamped)
            {
                mFillAmount = clamped;
                MarkAsChanged();
            }
        }
    }

    public override int minWidth
    {
        get
        {
            if (type == Type.Sliced || type == Type.Advanced)
            {
                Vector4 b = border;
                return Mathf.RoundToInt(b.x + b.z);
            }
            return base.minWidth;
        }
    }

    public override int minHeight
    {
        get
        {
            if (type == Type.Sliced || type == Type.Advanced)
            {
                Vector4 b = border;
                return Mathf.RoundToInt(b.y + b.w);
            }
            return base.minHeight;
        }
    }

    public bool invert
    {
        get
        {
            return mInvert;
        }
        set
        {
            if (mInvert != value)
            {
                mInvert = value;
                MarkAsChanged();
            }
        }
    }

    public virtual bool hasBorder
    {
        get
        {
            Vector4 b = border;
            return b.x != 0f || b.y != 0f || b.z != 0f || b.w != 0f;
        }
    }

    public virtual bool premultipliedAlpha
    {
        get
        {
            return false;
        }
    }

    public virtual float pixelSize
    {
        get
        {
            return 1f;
        }
    }

    protected virtual Vector4 padding
    {
        get
        {
            return Vector4.zero;
        }
    }

    protected Vector4 drawingUVs
    {
        get
        {
            switch (mFlip)
            {
                case Flip.Horizontally:
                    return new Vector4(mOuterUV.xMax, mOuterUV.yMin, mOuterUV.xMin, mOuterUV.yMax);
                case Flip.Vertically:
                    return new Vector4(mOuterUV.xMin, mOuterUV.yMax, mOuterUV.xMax, mOuterUV.yMin);
                case Flip.Both:
                    return new Vector4(mOuterUV.xMax, mOuterUV.yMax, mOuterUV.xMin, mOuterUV.yMin);
                default:
                    return new Vector4(mOuterUV.xMin, mOuterUV.yMin, mOuterUV.xMax, mOuterUV.yMax);
            }
        }
    }

    protected Color drawingColor
    {
        get
        {
            Color c = mColor;
            c.a *= finalAlpha;
            return c;
        }
    }

    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        Texture tex = mainTexture;
        if (tex == null) return;

        Vector4 v = drawingDimensions;
        Vector4 u = drawingUVs;
        Color c = drawingColor;

        if (mApplyGradient)
        {
            c.r *= mGradientTop.r;
            c.g *= mGradientTop.g;
            c.b *= mGradientTop.b;
            Color botC = mColor;
            botC.a *= finalAlpha;
            botC.r *= mGradientBottom.r;
            botC.g *= mGradientBottom.g;
            botC.b *= mGradientBottom.b;

            switch (mType)
            {
                case Type.Simple:
                    SimpleFill(verts, uvs, cols, ref v, ref u, ref c);
                    break;
                case Type.Sliced:
                    SlicedFill(verts, uvs, cols, ref v, ref u, ref c);
                    break;
                case Type.Tiled:
                    TiledFill(verts, uvs, cols, ref v, ref c);
                    break;
                case Type.Filled:
                    FilledFill(verts, uvs, cols, ref v, ref u, ref c);
                    break;
                case Type.Advanced:
                    AdvancedFill(verts, uvs, cols, ref v, ref u, ref c);
                    break;
            }
        }
        else
        {
            switch (mType)
            {
                case Type.Simple:
                    SimpleFill(verts, uvs, cols, ref v, ref u, ref c);
                    break;
                case Type.Sliced:
                    SlicedFill(verts, uvs, cols, ref v, ref u, ref c);
                    break;
                case Type.Tiled:
                    TiledFill(verts, uvs, cols, ref v, ref c);
                    break;
                case Type.Filled:
                    FilledFill(verts, uvs, cols, ref v, ref u, ref c);
                    break;
                case Type.Advanced:
                    AdvancedFill(verts, uvs, cols, ref v, ref u, ref c);
                    break;
            }
        }
    }

    protected void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, Rect outer, Rect inner)
    {
    }

    protected void SimpleFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
    {
        Fill(verts, uvs, cols, v.x, v.z, v.y, v.w, u.x, u.z, u.y, u.w, c);
    }

    protected void SlicedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color gc)
    {
        SimpleFill(verts, uvs, cols, ref v, ref u, ref gc);
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    private void AddVertexColours(List<Color> cols, ref Color color, int x, int y)
    {
        cols.Add(color);
    }

    protected void TiledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Color c)
    {
        Vector4 u = drawingUVs;
        SimpleFill(verts, uvs, cols, ref v, ref u, ref c);
    }

    protected void FilledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
    {
        SimpleFill(verts, uvs, cols, ref v, ref u, ref c);
    }

    protected void AdvancedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
    {
        SimpleFill(verts, uvs, cols, ref v, ref u, ref c);
    }

    private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
    {
        return true;
    }

    private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
    {
    }

    protected static void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
    {
        verts.Add(new Vector3(v0x, v0y, 0f));
        verts.Add(new Vector3(v0x, v1y, 0f));
        verts.Add(new Vector3(v1x, v1y, 0f));
        verts.Add(new Vector3(v1x, v0y, 0f));

        uvs.Add(new Vector2(u0x, u0y));
        uvs.Add(new Vector2(u0x, u1y));
        uvs.Add(new Vector2(u1x, u1y));
        uvs.Add(new Vector2(u1x, u0y));

        cols.Add(col);
        cols.Add(col);
        cols.Add(col);
        cols.Add(col);
    }
}