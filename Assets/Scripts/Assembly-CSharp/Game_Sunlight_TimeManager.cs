public class Game_Sunlight_TimeManager : System_Mover_Base
{
	public static readonly float s_dayTime_Default;

	private static float m_dayTime_Now;

	private static readonly float m_dayTime_Max;

	private static int m_hourNow;

	private static eTimeKind m_timeKindNow;

	public const int m_dayTime_Hour_Max = 24;

	public float m_weatherTime_CheckSec;

	public static readonly float m_weatherTime_CheckInterval;

	public static readonly float m_weatherTime_CheckHitWait;

	public static readonly float m_weatherTime_Percent;

	public static readonly int m_weatherSec_Min;

	public static readonly int m_weatherSec_Max;

	private static bool m_isCanusArea;

	public static float DayTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float GetDayTimePercent()
	{
		return 0f;
	}

	private static int CalcHour()
	{
		return 0;
	}

	public static int GetHour()
	{
		return 0;
	}

	public static eTimeKind CalcTimeKind(int hour)
	{
		return eTimeKind.T0002;
	}

	public static eTimeKind CalcTimeKind()
	{
		return eTimeKind.T0002;
	}

	public static eTimeKind GetTimeKind()
	{
		return eTimeKind.T0002;
	}

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected void CheckRain()
	{
	}

	protected void CheckSnow()
	{
	}
}
