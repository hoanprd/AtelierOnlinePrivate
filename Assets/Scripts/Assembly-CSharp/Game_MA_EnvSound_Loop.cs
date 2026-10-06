public class Game_MA_EnvSound_Loop : Game_MA_EnvSound_Base
{
	private Sound_Loop m_soundLoop;

	public bool[] m_activeTimeAry;

	public bool[] m_activeWeatherAy;

	protected void Update()
	{
	}

	public bool IsActiveTimeOK()
	{
		return false;
	}

	protected void Start()
	{
	}

	protected override void SetEnvSound()
	{
	}

	private void DestroySound()
	{
	}
}
