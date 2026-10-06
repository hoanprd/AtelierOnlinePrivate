public class DB_OptionData
{
	public enum eSoundKind
	{
		Music = 0,
		Sound = 1,
		Voice = 2,
		EnumMax = 3
	}

	public static readonly float sc_fSound_Volume_Mute;

	public static readonly float sc_fMusic_Volume_Default;

	public static readonly float sc_fSound_Volume_Default;

	public static readonly float sc_fSound_Volume_Movie;

	private bool[] m_bSound_MuteFlag;

	private float[] m_fSound_Volume;

	public void Initialize()
	{
	}

	public void SetSound_Volume(eSoundKind eKind, float fVolume)
	{
	}

	public float GetSound_Volume(eSoundKind eKind)
	{
		return 0f;
	}

	public void SetSound_Mute(eSoundKind eKind, bool bFlag)
	{
	}

	public bool IsSound_Mute(eSoundKind eKind)
	{
		return false;
	}
}
