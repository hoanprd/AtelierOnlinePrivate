using System.Collections.Generic;
using UnityEngine;

public class Game_MA_EnvSound_Base : MonoBehaviour
{
	public enum eEnvSoundKind
	{
		field_000 = 0,
		field_001 = 1,
		field_002 = 2,
		field_003 = 3,
		field_004 = 4,
		field_005 = 5,
		field_006 = 6,
		field_007 = 7,
		field_008 = 8,
		field_009 = 9,
		field_010 = 10,
		field_011 = 11,
		field_012 = 12,
		field_013 = 13,
		field_014 = 14,
		field_015 = 15,
		field_016 = 16,
		field_017 = 17,
		field_018 = 18,
		field_019 = 19,
		field_020 = 20,
		field_021 = 21,
		field_022 = 22,
		field_023 = 23,
		field_024 = 24,
		field_025 = 25,
		field_026 = 26,
		field_027 = 27,
		field_028 = 28,
		field_029 = 29,
		field_030 = 30,
		field_031 = 31,
		field_032 = 32,
		field_033 = 33,
		field_034 = 34,
		field_035 = 35,
		field_036 = 36,
		field_037 = 37,
		field_038 = 38,
		field_039 = 39,
		field_040 = 40,
		field_041 = 41,
		field_042 = 42,
		field_043 = 43,
		field_044 = 44,
		field_045 = 45,
		field_046 = 46,
		field_047 = 47,
		field_048 = 48,
		field_049 = 49,
		field_050 = 50,
		field_051 = 51,
		field_052 = 52,
		field_053 = 53,
		field_054 = 54,
		field_055 = 55,
		field_056 = 56,
		field_057 = 57,
		field_058 = 58,
		field_059 = 59,
		field_060 = 60,
		field_061 = 61,
		field_062 = 62,
		field_063 = 63,
		field_064 = 64,
		field_065 = 65,
		field_066 = 66,
		field_067 = 67,
		field_068 = 68,
		field_069 = 69,
		EnumMax = 70
	}

	protected static readonly eSoundID[] m_soundIdExchangeTable;

	public eEnvSoundKind m_callEnvSoundKind;

	public float m_hearDist_Near;

	public float m_hearDist_Far;

	public bool m_limitMusicVolumeFlag;

	[LocalLine]
	[HideInInspector]
	public List<LocalLine> m_checkDistLines;

	public bool m_useDistVolmue;

	protected eSoundID m_directSoundId;

	protected static List<Sound_OneShot> m_limitMusicSoundList;

	public static float GetMaxVolumePercent()
	{
		return 0f;
	}

	protected virtual void SetEnvSound()
	{
	}
}
