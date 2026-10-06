using UnityEngine;

public class Game_MA_EnvSound_Sometimes : Game_MA_EnvSound_Base
{
	[SerializeField]
	private float m_rondomPer;

	[SerializeField]
	private float m_checkTime;

	private float m_waitTime;

	public void Init(eSoundID sound, float per, float time, bool useDistVolume)
	{
	}

	public void Init(eEnvSoundKind sound, float per, float time, bool useDistVolume)
	{
	}

	private void Update()
	{
	}
}
