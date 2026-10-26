using System;
using System.Diagnostics;
using UnityEngine;

public static class NGUIMath
{
    [DebuggerHidden]
    [DebuggerStepThrough]
    public static float Lerp(float from, float to, float factor)
    {
        return from + (to - from) * factor;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static int ClampIndex(int val, int max)
    {
        return (val < 0) ? 0 : (val >= max ? max - 1 : val);
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static int RepeatIndex(int val, int max)
    {
        if (max < 1) return 0;
        int num = val % max;
        return (num < 0) ? num + max : num;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static float WrapAngle(float angle)
    {
        while (angle > 180f) angle -= 360f;
        while (angle < -180f) angle += 360f;
        return angle;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static float Wrap01(float val)
    {
        return val - Mathf.Floor(val);
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static int HexToDecimal(char ch)
    {
        switch (ch)
        {
            case '0': return 0;
            case '1': return 1;
            case '2': return 2;
            case '3': return 3;
            case '4': return 4;
            case '5': return 5;
            case '6': return 6;
            case '7': return 7;
            case '8': return 8;
            case '9': return 9;
            case 'a':
            case 'A': return 10;
            case 'b':
            case 'B': return 11;
            case 'c':
            case 'C': return 12;
            case 'd':
            case 'D': return 13;
            case 'e':
            case 'E': return 14;
            case 'f':
            case 'F': return 15;
        }
        return 0;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static char DecimalToHexChar(int num)
    {
        if (num > 15) return 'F';
        if (num < 0) return '0';
        return num < 10 ? (char)('0' + num) : (char)('A' + (num - 10));
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static string DecimalToHex8(int num)
    {
        num &= 0xFF;
        return num.ToString("X2");
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static string DecimalToHex24(int num)
    {
        num &= 0xFFFFFF;
        return num.ToString("X6");
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static string DecimalToHex32(int num)
    {
        return num.ToString("X8");
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static int ColorToInt(Color c)
    {
        int ret = 0;
        ret |= Mathf.RoundToInt(c.r * 255f) << 24;
        ret |= Mathf.RoundToInt(c.g * 255f) << 16;
        ret |= Mathf.RoundToInt(c.b * 255f) << 8;
        ret |= Mathf.RoundToInt(c.a * 255f);
        return ret;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static Color IntToColor(int val)
    {
        float inv = 1f / 255f;
        Color c = new Color(
            inv * ((val >> 24) & 0xFF),
            inv * ((val >> 16) & 0xFF),
            inv * ((val >> 8) & 0xFF),
            inv * (val & 0xFF));
        return c;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static string IntToBinary(int val, int bits)
    {
        string s = "";
        for (int i = bits - 1; i >= 0; --i)
        {
            s += ((val & (1 << i)) != 0) ? "1" : "0";
        }
        return s;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public static Color HexToColor(uint val)
    {
        return IntToColor((int)val);
    }

    public static Rect ConvertToTexCoords(Rect rect, int width, int height)
    {
        if (width != 0 && height != 0)
        {
            rect.xMin /= width;
            rect.xMax /= width;
            rect.yMin /= height;
            rect.yMax /= height;
        }
        return rect;
    }

    public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
    {
        if (round)
        {
            rect.xMin = Mathf.RoundToInt(rect.xMin * width);
            rect.xMax = Mathf.RoundToInt(rect.xMax * width);
            rect.yMin = Mathf.RoundToInt(rect.yMin * height);
            rect.yMax = Mathf.RoundToInt(rect.yMax * height);
        }
        else
        {
            rect.xMin *= width;
            rect.xMax *= width;
            rect.yMin *= height;
            rect.yMax *= height;
        }
        return rect;
    }

    public static Rect MakePixelPerfect(Rect rect)
    {
        rect.x = Mathf.RoundToInt(rect.x);
        rect.y = Mathf.RoundToInt(rect.y);
        rect.width = Mathf.RoundToInt(rect.width);
        rect.height = Mathf.RoundToInt(rect.height);
        return rect;
    }

    public static Rect MakePixelPerfect(Rect rect, int width, int height)
    {
        rect = ConvertToPixels(rect, width, height, true);
        rect = ConvertToTexCoords(rect, width, height);
        return rect;
    }

    public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
    {
        Vector2 offset = Vector2.zero;

        Vector2 min = minRect;
        Vector2 max = maxRect;

        if (min.x < minArea.x) offset.x += minArea.x - min.x;
        if (max.x > maxArea.x) offset.x += maxArea.x - max.x;
        if (min.y < minArea.y) offset.y += minArea.y - min.y;
        if (max.y > maxArea.y) offset.y += maxArea.y - max.y;

        return offset;
    }

    public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
    {
        if (trans != null)
        {
            UIWidget[] widgets = trans.GetComponentsInChildren<UIWidget>(true);
            if (widgets.Length > 0)
            {
                Vector3 vMin = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
                Vector3 vMax = new Vector3(float.MinValue, float.MinValue, float.MinValue);

                for (int i = 0, imax = widgets.Length; i < imax; ++i)
                {
                    UIWidget w = widgets[i];
                    if (!w.enabled) continue;

                    Vector3[] corners = w.worldCorners;
                    for (int j = 0; j < 4; ++j)
                    {
                        Vector3 v = corners[j];
                        if (v.x < vMin.x) vMin.x = v.x;
                        if (v.y < vMin.y) vMin.y = v.y;
                        if (v.z < vMin.z) vMin.z = v.z;

                        if (v.x > vMax.x) vMax.x = v.x;
                        if (v.y > vMax.y) vMax.y = v.y;
                        if (v.z > vMax.z) vMax.z = v.z;
                    }
                }
                Bounds b = new Bounds(vMin, Vector3.zero);
                b.Encapsulate(vMax);
                return b;
            }
        }
        return new Bounds(Vector3.zero, Vector3.zero);
    }

    public static Bounds CalculateRelativeWidgetBounds(Transform trans)
    {
        return CalculateRelativeWidgetBounds(trans, trans, true, true);
    }

    public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
    {
        return CalculateRelativeWidgetBounds(trans, trans, considerInactive, true);
    }

    public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
    {
        return CalculateRelativeWidgetBounds(relativeTo, content, true, true);
    }

    public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerChildren = true)
    {
        Matrix4x4 toLocal = relativeTo.worldToLocalMatrix;
        Vector3 vMin = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
        Vector3 vMax = new Vector3(float.MinValue, float.MinValue, float.MinValue);
        bool isSet = false;

        CalculateRelativeWidgetBounds(content, considerInactive, true, ref toLocal, ref vMin, ref vMax, ref isSet, considerChildren);

        if (isSet)
        {
            Bounds b = new Bounds(vMin, Vector3.zero);
            b.Encapsulate(vMax);
            return b;
        }
        return new Bounds(Vector3.zero, Vector3.zero);
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    private static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerChildren)
    {
        if (content == null) return;
        if (!considerInactive && !NGUITools.GetActive(content.gameObject)) return;

        UIWidget w = content.GetComponent<UIWidget>();
        if (w != null && w.enabled)
        {
            Vector3[] corners = w.worldCorners;
            for (int j = 0; j < 4; ++j)
            {
                Vector3 v = toLocal.MultiplyPoint3x4(corners[j]);

                if (v.x < vMin.x) vMin.x = v.x;
                if (v.y < vMin.y) vMin.y = v.y;
                if (v.z < vMin.z) vMin.z = v.z;

                if (v.x > vMax.x) vMax.x = v.x;
                if (v.y > vMax.y) vMax.y = v.y;
                if (v.z > vMax.z) vMax.z = v.z;

                isSet = true;
            }
        }

        if (considerChildren)
        {
            for (int i = 0, imax = content.childCount; i < imax; ++i)
            {
                CalculateRelativeWidgetBounds(content.GetChild(i), considerInactive, false, ref toLocal, ref vMin, ref vMax, ref isSet, true);
            }
        }
    }

    public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
    {
        if (deltaTime > 1f) deltaTime = 1f;
        float mult = 1f - strength * 0.05f;
        int iterations = Mathf.RoundToInt(deltaTime * 60f);
        if (iterations < 1) iterations = 1;
        float dt = deltaTime / iterations;
        Vector3 v = Vector3.zero;

        for (int i = 0; i < iterations; ++i)
        {
            velocity *= Mathf.Pow(mult, dt * 60f);
            v += velocity * dt;
        }
        return v;
    }

    public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
    {
        if (deltaTime > 1f) deltaTime = 1f;
        float mult = 1f - strength * 0.05f;
        int iterations = Mathf.RoundToInt(deltaTime * 60f);
        if (iterations < 1) iterations = 1;
        float dt = deltaTime / iterations;
        Vector2 v = Vector2.zero;

        for (int i = 0; i < iterations; ++i)
        {
            velocity *= Mathf.Pow(mult, dt * 60f);
            v += velocity * dt;
        }
        return v;
    }

    public static float SpringLerp(float strength, float deltaTime)
    {
        if (deltaTime > 1f) deltaTime = 1f;
        int iterations = Mathf.RoundToInt(deltaTime * 60f);
        if (iterations < 1) iterations = 1;
        float dt = deltaTime / iterations;
        float val = 0f;
        for (int i = 0; i < iterations; ++i)
        {
            val = Mathf.Lerp(val, 1f, dt * strength);
        }
        return val;
    }

    public static float SpringLerp(float from, float to, float strength, float deltaTime)
    {
        if (deltaTime > 1f) deltaTime = 1f;
        int iterations = Mathf.RoundToInt(deltaTime * 60f);
        if (iterations < 1) iterations = 1;
        float dt = deltaTime / iterations;
        for (int i = 0; i < iterations; ++i)
        {
            from = Mathf.Lerp(from, to, dt * strength);
        }
        return from;
    }

    public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
    {
        return Vector2.Lerp(from, to, SpringLerp(strength, deltaTime));
    }

    public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
    {
        return Vector3.Lerp(from, to, SpringLerp(strength, deltaTime));
    }

    public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
    {
        return Quaternion.Slerp(from, to, SpringLerp(strength, deltaTime));
    }

    public static float RotateTowards(float from, float to, float maxAngle)
    {
        float diff = WrapAngle(to - from);
        if (Mathf.Abs(diff) > maxAngle) diff = maxAngle * Mathf.Sign(diff);
        return from + diff;
    }

    private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
    {
        Vector2 ab = b - a;
        float sqrLen = ab.sqrMagnitude;
        if (sqrLen == 0f) return Vector2.Distance(point, a);
        float t = Vector2.Dot(point - a, ab) / sqrLen;
        t = Mathf.Clamp01(t);
        Vector2 projection = a + t * ab;
        return Vector2.Distance(point, projection);
    }

    public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
    {
        bool inside = false;
        float closestSqrDist = float.MaxValue;

        for (int i = 0, j = 4 - 1; i < 4; j = i++)
        {
            Vector2 p0 = screenPoints[i];
            Vector2 p1 = screenPoints[j];

            if (((p0.y <= mousePos.y && mousePos.y < p1.y) || (p1.y <= mousePos.y && mousePos.y < p0.y)) &&
                (mousePos.x < (p1.x - p0.x) * (mousePos.y - p0.y) / (p1.y - p0.y) + p0.x))
            {
                inside = !inside;
            }

            float sqrDist = DistancePointToLineSegment(mousePos, p0, p1);
            if (sqrDist < closestSqrDist) closestSqrDist = sqrDist;
        }

        return inside ? -closestSqrDist : closestSqrDist;
    }

    public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
    {
        Vector2[] screenPoints = new Vector2[4];
        for (int i = 0; i < 4; ++i)
        {
            screenPoints[i] = cam.WorldToScreenPoint(worldPoints[i]);
        }
        return DistanceToRectangle(screenPoints, mousePos);
    }

    public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
    {
        Vector2 v = Vector2.zero;

        switch (pv)
        {
            case UIWidget.Pivot.TopLeft:
            case UIWidget.Pivot.Left:
            case UIWidget.Pivot.BottomLeft:
                v.x = 0f;
                break;
            case UIWidget.Pivot.Top:
            case UIWidget.Pivot.Center:
            case UIWidget.Pivot.Bottom:
                v.x = 0.5f;
                break;
            case UIWidget.Pivot.TopRight:
            case UIWidget.Pivot.Right:
            case UIWidget.Pivot.BottomRight:
                v.x = 1f;
                break;
        }

        switch (pv)
        {
            case UIWidget.Pivot.BottomLeft:
            case UIWidget.Pivot.Bottom:
            case UIWidget.Pivot.BottomRight:
                v.y = 0f;
                break;
            case UIWidget.Pivot.Left:
            case UIWidget.Pivot.Center:
            case UIWidget.Pivot.Right:
                v.y = 0.5f;
                break;
            case UIWidget.Pivot.TopLeft:
            case UIWidget.Pivot.Top:
            case UIWidget.Pivot.TopRight:
                v.y = 1f;
                break;
        }
        return v;
    }

    public static UIWidget.Pivot GetPivot(Vector2 offset)
    {
        if (offset.x == 0f)
        {
            if (offset.y == 0f) return UIWidget.Pivot.BottomLeft;
            if (offset.y == 1f) return UIWidget.Pivot.TopLeft;
            return UIWidget.Pivot.Left;
        }
        if (offset.x == 1f)
        {
            if (offset.y == 0f) return UIWidget.Pivot.BottomRight;
            if (offset.y == 1f) return UIWidget.Pivot.TopRight;
            return UIWidget.Pivot.Right;
        }
        if (offset.y == 0f) return UIWidget.Pivot.Bottom;
        if (offset.y == 1f) return UIWidget.Pivot.Top;
        return UIWidget.Pivot.Center;
    }

    public static void MoveWidget(UIRect w, float x, float y)
    {
        Vector3 v = new Vector3(x, y, 0f);
        if (w.cachedTransform.parent != null)
        {
            v = w.cachedTransform.parent.InverseTransformPoint(w.cachedTransform.position + v);
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            w.cachedTransform.localPosition = v;
        }
        else
        {
            v += w.cachedTransform.position;
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            w.cachedTransform.position = v;
        }
    }

    public static void MoveRect(UIRect rect, float x, float y)
    {
        MoveWidget(rect, x, y);
    }

    public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
    {
        ResizeWidget(w, pivot, x, y, minWidth, minHeight, int.MaxValue, int.MaxValue);
    }

    public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
    {
        Vector3 p = w.cachedTransform.localPosition;
        Vector2 size = w.localSize;

        switch (pivot)
        {
            case UIWidget.Pivot.BottomLeft:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x - x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y - y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
            case UIWidget.Pivot.Left:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x - x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
            case UIWidget.Pivot.Bottom:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y - y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
            case UIWidget.Pivot.BottomRight:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x + x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y - y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
            case UIWidget.Pivot.Right:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x + x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
            case UIWidget.Pivot.TopRight:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x + x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y + y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
            case UIWidget.Pivot.Top:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y + y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
            case UIWidget.Pivot.TopLeft:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x - x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y + y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
            case UIWidget.Pivot.Center:
                {
                    int w2 = Mathf.Clamp(Mathf.RoundToInt(size.x), minWidth, maxWidth);
                    int h2 = Mathf.Clamp(Mathf.RoundToInt(size.y), minHeight, maxHeight);
                    if (w2 != size.x || h2 != size.y)
                    {
                        w.SetRect(p.x, p.y, w2, h2);
                    }
                    break;
                }
        }
    }

    public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
    {
        AdjustWidget(w, left, bottom, right, top, 2, 2);
    }

    public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
    {
        AdjustWidget(w, left, bottom, right, top, minWidth, minHeight, int.MaxValue, int.MaxValue);
    }

    public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
    {
        Vector4 rect = w.drawingDimensions;
        Vector3 pos = w.cachedTransform.localPosition;

        rect.x += left;
        rect.y += bottom;
        rect.z += right;
        rect.w += top;

        int w2 = Mathf.RoundToInt(rect.z - rect.x);
        int h2 = Mathf.RoundToInt(rect.w - rect.y);

        if (w2 < minWidth) w2 = minWidth;
        if (h2 < minHeight) h2 = minHeight;

        w.SetRect(pos.x, pos.y, w2, h2);
    }

    public static int AdjustByDPI(float height)
    {
        float dpi = Screen.dpi;
        if (dpi == 0f) dpi = 96f;
        return Mathf.RoundToInt(height * (96f / dpi));
    }

    public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
    {
        Camera cam = NGUITools.FindCameraForLayer(relativeTo.gameObject.layer);
        if (cam == null) return pos;
        Vector3 wp = cam.ScreenToWorldPoint(pos);
        return relativeTo.InverseTransformPoint(wp);
    }

    public static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
    {
        Camera cam = NGUITools.FindCameraForLayer(relativeTo.gameObject.layer);
        if (cam == null) return pos;
        Vector3 wp = cam.ScreenToWorldPoint(pos);
        if (relativeTo.parent != null)
        {
            return relativeTo.parent.InverseTransformPoint(wp);
        }
        return wp;
    }

    public static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo)
    {
        Vector3 screen = worldCam.WorldToScreenPoint(worldPos);
        Vector3 wp = uiCam.ScreenToWorldPoint(screen);
        return relativeTo.InverseTransformPoint(wp);
    }

    public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
    {
        Vector3 screen = worldCam.WorldToScreenPoint(worldPos);
        trans.position = myCam.ScreenToWorldPoint(screen);
    }

    public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam)
    {
        Camera myCam = NGUITools.FindCameraForLayer(trans.gameObject.layer);
        if (myCam != null) OverlayPosition(trans, worldPos, worldCam, myCam);
    }

    public static void OverlayPosition(this Transform trans, Transform target)
    {
        Camera worldCam = NGUITools.FindCameraForLayer(target.gameObject.layer);
        if (worldCam != null) OverlayPosition(trans, target.position, worldCam);
    }
}