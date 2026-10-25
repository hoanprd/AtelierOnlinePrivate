using System.Collections.Generic;
using UnityEngine;

public class UIGeometry
{
    public delegate void OnCustomWrite(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2);

    public List<Vector3> verts = new List<Vector3>();

    public List<Vector2> uvs = new List<Vector2>();

    public List<Color> cols = new List<Color>();

    public OnCustomWrite onCustomWrite;

    private List<Vector3> mRtpVerts = new List<Vector3>();

    private Vector3 mRtpNormal;

    private Vector4 mRtpTan;

    public bool hasVertices
    {
        get
        {
            return verts != null && verts.Count > 0;
        }
    }

    public bool hasTransformed
    {
        get
        {
            return mRtpVerts != null && verts != null && mRtpVerts.Count == verts.Count;
        }
    }

    public void Clear()
    {
        verts.Clear();
        uvs.Clear();
        cols.Clear();
        mRtpVerts.Clear();
    }

    public void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals = true)
    {
        if (verts.Count > 0)
        {
            mRtpVerts.Clear();
            for (int i = 0, imax = verts.Count; i < imax; ++i)
            {
                mRtpVerts.Add(widgetToPanel.MultiplyPoint3x4(verts[i]));
            }
        }
        else
        {
            mRtpVerts.Clear();
        }
    }

    public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
    {
        if (mRtpVerts.Count > 0)
        {
            if (onCustomWrite != null)
            {
                onCustomWrite(v, u, c, n, t, u2);
            }
            else
            {
                for (int i = 0, imax = mRtpVerts.Count; i < imax; ++i)
                {
                    v.Add(mRtpVerts[i]);
                    u.Add(uvs[i]);
                    c.Add(cols[i]);
                }
            }
        }
    }
}