using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UITexture : UIBasicSprite
{
    [HideInInspector]
    [SerializeField]
    private Rect mRect = new Rect(0f, 0f, 1f, 1f);

    [HideInInspector]
    [SerializeField]
    private Texture mTexture;

    [HideInInspector]
    [SerializeField]
    private Shader mShader;

    [HideInInspector]
    [SerializeField]
    private Vector4 mBorder = Vector4.zero;

    [HideInInspector]
    [SerializeField]
    private bool mFixedAspect;

    [NonSerialized]
    private int mPMA = -1;

    public override Texture mainTexture
    {
        get
        {
            if (mTexture != null)
            {
                return mTexture;
            }
            return base.mainTexture;
        }
        set
        {
            if (mTexture != value)
            {
                mTexture = value;
                MarkAsChanged();
            }
        }
    }

    public override Material material
    {
        get
        {
            Material mat = base.material;
            if (mat != null)
            {
                return mat;
            }
            return null;
        }
        set
        {
            base.material = value;
        }
    }

    public override Shader shader
    {
        get
        {
            if (mShader != null)
            {
                return mShader;
            }
            Material mat = material;
            if (mat != null)
            {
                return mat.shader;
            }
            return base.shader;
        }
        set
        {
            mShader = value;
            Material mat = material;
            if (mat != null)
            {
                mat.shader = value;
            }
            mPMA = -1;
        }
    }

    public override bool premultipliedAlpha
    {
        get
        {
            if (mPMA == -1)
            {
                Shader sh = shader;
                mPMA = (sh != null && sh.name.Contains("Premultiplied")) ? 1 : 0;
            }
            return mPMA == 1;
        }
    }

    public override Vector4 border
    {
        get
        {
            return mBorder;
        }
        set
        {
            if (mBorder != value)
            {
                mBorder = value;
                MarkAsChanged();
            }
        }
    }

    public Rect uvRect
    {
        get
        {
            return mRect;
        }
        set
        {
            if (mRect.xMin != value.xMin || mRect.yMin != value.yMin || mRect.xMax != value.xMax || mRect.yMax != value.yMax)
            {
                mRect = value;
                MarkAsChanged();
            }
        }
    }

    public override Vector4 drawingDimensions
    {
        get
        {
            return base.drawingDimensions;
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

    public override void MakePixelPerfect()
    {
        Texture tex = mainTexture;
        if (tex != null)
        {
            int w = tex.width;
            int h = tex.height;
            if ((w & 1) == 1) w++;
            if ((h & 1) == 1) h++;
            width = w;
            height = h;
            base.MakePixelPerfect();
        }
    }

    protected override void OnUpdate()
    {
        if (mFixedAspect)
        {
            Texture tex = mainTexture;
            if (tex != null)
            {
                int w = tex.width;
                int h = tex.height;
                int dw = Mathf.RoundToInt(mRect.width * w);
                int dh = Mathf.RoundToInt(mRect.height * h);
                if (dw > 0 && dh > 0)
                {
                    float f1 = (float)width / (float)height;
                    float f2 = (float)dw / (float)dh;
                    if (f1 < f2)
                    {
                        int nb = Mathf.RoundToInt((float)width / f2);
                        if (nb != height)
                        {
                            height = nb;
                            MarkAsChanged();
                        }
                    }
                    else if (f1 > f2)
                    {
                        int nw = Mathf.RoundToInt((float)height * f2);
                        if (nw != width)
                        {
                            width = nw;
                            MarkAsChanged();
                        }
                    }
                }
            }
        }
        base.OnUpdate();
    }

    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        Texture tex = mainTexture;
        if (tex == null) return;

        Vector4 v = drawingDimensions;
        Vector4 u = new Vector4(mRect.xMin, mRect.yMin, mRect.xMax, mRect.yMax);

        Color col = color;
        col.a *= mColor.a;

        if (premultipliedAlpha)
        {
            col.r *= col.a;
            col.g *= col.a;
            col.b *= col.a;
        }

        verts.Add(new Vector3(v.x, v.y, 0f));
        verts.Add(new Vector3(v.x, v.w, 0f));
        verts.Add(new Vector3(v.z, v.w, 0f));
        verts.Add(new Vector3(v.z, v.y, 0f));

        uvs.Add(new Vector2(u.x, u.y));
        uvs.Add(new Vector2(u.x, u.w));
        uvs.Add(new Vector2(u.z, u.w));
        uvs.Add(new Vector2(u.z, u.y));

        cols.Add(col);
        cols.Add(col);
        cols.Add(col);
        cols.Add(col);
    }
}