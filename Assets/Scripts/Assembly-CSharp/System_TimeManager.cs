using UnityEngine;

public class System_TimeManager : MonoBehaviour
{
    public static readonly float sc_fTimeScale_Menu = 1f;

    private static float s_fTimeScale_Now = 1f;

    private void Awake()
    {
        s_fTimeScale_Now = 1f;
        Time.timeScale = s_fTimeScale_Now;
    }

    private void Update()
    {
        // Đồng bộ thời gian scale của Unity với TimeManager
        if (Mathf.Abs(Time.timeScale - s_fTimeScale_Now) > 0.001f)
        {
            Time.timeScale = s_fTimeScale_Now;
        }
    }

    public static float GetTimeScale()
    {
        return s_fTimeScale_Now;
    }

    public static void SetTimeScale_Default()
    {
        s_fTimeScale_Now = 1f;
        Time.timeScale = 1f;
    }

    public static void SetTimeScale(float fScale)
    {
        s_fTimeScale_Now = Mathf.Max(0f, fScale);
        Time.timeScale = s_fTimeScale_Now;
    }

    public static float GetDeltaTime()
    {
        return Time.deltaTime;
    }

    public static float GetDeltaTime_RealTime()
    {
        return Time.unscaledDeltaTime;
    }

    public static float GetMoverTimeScale()
    {
        // Có thể nhân thêm hệ số tùy chỉnh cho di chuyển nếu cần, tạm thời trả về TimeScale chung
        return s_fTimeScale_Now;
    }

    public static float GetAnimationTimeScale()
    {
        return s_fTimeScale_Now;
    }
}