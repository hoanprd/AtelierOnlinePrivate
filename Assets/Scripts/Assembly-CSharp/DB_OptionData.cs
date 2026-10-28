using UnityEngine;

public class DB_OptionData
{
	public enum eSoundKind
	{
		Music = 0,
		Sound = 1,
		Voice = 2,
		EnumMax = 3
	}

	public static readonly float sc_fSound_Volume_Mute = 0f;

	public static readonly float sc_fMusic_Volume_Default = 0.8f;

	public static readonly float sc_fSound_Volume_Default = 0.8f;

	public static readonly float sc_fSound_Volume_Movie = 0.8f;

	private bool[] m_bSound_MuteFlag = new bool[(int)eSoundKind.EnumMax];

	private float[] m_fSound_Volume = new float[(int)eSoundKind.EnumMax] { 0.8f, 0.8f, 0.8f };

	public void Initialize()
	{
		if (m_bSound_MuteFlag == null || m_bSound_MuteFlag.Length < (int)eSoundKind.EnumMax)
		{
			m_bSound_MuteFlag = new bool[(int)eSoundKind.EnumMax];
		}
		if (m_fSound_Volume == null || m_fSound_Volume.Length < (int)eSoundKind.EnumMax)
		{
			m_fSound_Volume = new float[(int)eSoundKind.EnumMax];
		}
		m_bSound_MuteFlag[(int)eSoundKind.Music] = false;
		m_bSound_MuteFlag[(int)eSoundKind.Sound] = false;
		m_bSound_MuteFlag[(int)eSoundKind.Voice] = false;
		m_fSound_Volume[(int)eSoundKind.Music] = sc_fMusic_Volume_Default;
		m_fSound_Volume[(int)eSoundKind.Sound] = sc_fSound_Volume_Default;
		m_fSound_Volume[(int)eSoundKind.Voice] = sc_fSound_Volume_Default;
	}

	public void SetSound_Volume(eSoundKind eKind, float fVolume)
	{
		if (m_fSound_Volume == null)
		{
			Initialize();
		}
		int idx = (int)eKind;
		if (idx >= 0 && idx < m_fSound_Volume.Length)
		{
			m_fSound_Volume[idx] = Mathf.Clamp01(fVolume);
		}
	}

	public float GetSound_Volume(eSoundKind eKind)
	{
		if (m_fSound_Volume == null || m_bSound_MuteFlag == null)
		{
			Initialize();
		}
		int idx = (int)eKind;
		if (idx < 0 || idx >= m_fSound_Volume.Length)
		{
			return sc_fSound_Volume_Default;
		}
		if (m_bSound_MuteFlag[idx])
		{
			return sc_fSound_Volume_Mute;
		}
		return m_fSound_Volume[idx];
	}

	public void SetSound_Mute(eSoundKind eKind, bool bFlag)
	{
		if (m_bSound_MuteFlag == null)
		{
			Initialize();
		}
		int idx = (int)eKind;
		if (idx >= 0 && idx < m_bSound_MuteFlag.Length)
		{
			m_bSound_MuteFlag[idx] = bFlag;
		}
	}

	public bool IsSound_Mute(eSoundKind eKind)
	{
		if (m_bSound_MuteFlag == null)
		{
			Initialize();
		}
		int idx = (int)eKind;
		if (idx < 0 || idx >= m_bSound_MuteFlag.Length)
		{
			return false;
		}
		return m_bSound_MuteFlag[idx];
	}
}
