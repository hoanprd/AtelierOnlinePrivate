using UnityEngine;

public class Game_Sunlight_FilterManager : System_Mover_Base
{
	public enum eRainKind
	{
		Default = 0,
		ForceNG = 1,
		ForceRain = 2,
		ForceSnow = 3
	}

	public enum eLightKind
	{
		Day0 = 0,
		Day4 = 1,
		Day6 = 2,
		Day8 = 3,
		Night0 = 4,
		Night4 = 5,
		Night6 = 6,
		Night8 = 7,
		EnumMax = 8
	}

	public enum EColorFilterBlendType
	{
		eNONE = 0,
		eANIM2FIX = 1,
		eFIX2ANIM = 2
	}

	private static Game_Sunlight_FilterManager m_inst;

	public static readonly int m_lightCycle;

	private AreaInfo.ESunlightKind m_colorBlendPlayType;

	private EColorFilterBlendType m_colorBlendType;

	private float m_colorBlendTime;

	private Vector4[] m_colorBlendTarget;

	private Vector4[] m_colorBlendPrev;

	public CameraColorControl m_colorFilter;

	public Animation m_colorAnim;

	public AnimationClip m_defaultFilter;

	public Vector4[] m_colorFixed;

	private GameObject m_rainEffect_Log;

	private Sound_Loop m_rainSound_Log;

	private GameObject m_snowEffect_Log;

	private eLightKind m_forceLight_Now;

	private eWeather m_forceWeeather_Now;

	private eWeather m_weatherNow;

	private bool m_rainActive;

	private float m_rainAlpha_Now;

	private float m_rainTime_Now;

	private float m_rainTime_After_Now;

	private float m_rainTime_After_Max;

	private static readonly float m_rainAlphaChangePerSec;

	private bool m_snowActive;

	private float m_snowAlpha_Now;

	private float m_snowTime_Now;

	private float m_snowTime_After_Now;

	private float m_snowTime_After_Max;

	private static readonly float m_snowAlphaChangePerSec;

	private GameObject m_zoneEffect_Log;

	private eLightKind[] m_lightCycleArray;

	private int[] m_lightChangeHour;

	public static float RainTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float SnowTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static Game_Sunlight_FilterManager GetInst()
	{
		return null;
	}

	protected override void OnDestroy()
	{
	}

	public void SetEnable(bool sw)
	{
	}

	private void SetParticleEmitNum(Transform parent, int max)
	{
	}

	protected void OnDisable()
	{
	}

	public void RainActive(bool active)
	{
	}

	public void SnowActive(bool active)
	{
	}

	protected override void Awake()
	{
	}

	private void UpdateColorFilter()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	private bool UpdateRainFilter(float rainTime_Now)
	{
		return false;
	}

	private bool UpdateSnowFilter(float snowTime_Now)
	{
		return false;
	}

	public bool IsRain()
	{
		return false;
	}

	public bool IsAfterRain()
	{
		return false;
	}

	public bool IsSnow()
	{
		return false;
	}

	public eWeather GetWeather()
	{
		return eWeather.Sun;
	}

	private eLightKind GetLightKind()
	{
		return eLightKind.Day0;
	}

	public eLightKind GetLightKind_Filter()
	{
		return eLightKind.Day0;
	}

	private float GetLightPercent()
	{
		return 0f;
	}

	public void SetForceWeatherKind(eWeather weather)
	{
	}

	public void SetForceLightKind(eLightKind kind, eWeather weather)
	{
	}

	public void SetFilterAnimation(AnimationClip clip)
	{
	}

	public void SetFilterAnimation(string path)
	{
	}

	public void SetFilterDefaultAnimation()
	{
	}

	public void SetFilter(Vector4 r, Vector4 g, Vector4 b, eWeather forceWeather = eWeather.Sun)
	{
	}

	public void SetFilter(Vector4[] rgb, eWeather forceWeather = eWeather.Sun)
	{
	}

	public void OverwriteFilter(Vector4[] rgb)
	{
	}

	public void OverwriteEnd()
	{
	}

	public void TextBlend()
	{
	}

	public void TextBlend2()
	{
	}

	public static Vector4[] Convert(string param)
	{
		return null;
	}
}
