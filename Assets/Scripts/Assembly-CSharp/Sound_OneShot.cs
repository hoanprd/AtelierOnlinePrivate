using UnityEngine;

public class Sound_OneShot : System_Mover_Base
{
	public static float s_fEnvSeScale;

	public GameObject m_goSpeakerObj;

	public GameObject m_goListenerObj;

	public float m_fVolumeDist_Near;

	public float m_fVolumeDist_Far;

	public LocalLine[] m_cLines;

	protected bool m_bTimeScale;

	public AudioSource m_asTargetSource;

	public bool m_bIgnorePause;

	protected bool m_bReverbFlag;

	protected float m_fWaitSec_Start;

	protected bool m_bStartedFlag;

	protected bool m_bEnvSe;

	public bool EnvSe
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Initialize()
	{
	}

	protected override void MoverUpdate_Pause()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected void CheckVolume()
	{
	}

	public void UpdateVolume()
	{
	}

	public void SetVolume(float volNow)
	{
	}

	public float GetVolumePercent()
	{
		return 0f;
	}

	public void SetPlayTiming(float fWaitSec)
	{
	}

	public void SetDistanceVolume(GameObject speaker, GameObject listener, float near, float far, LocalLine[] lines = null)
	{
	}

	public void SetTimeScale(bool sw)
	{
	}

	public void SetReverb(bool enableFlag)
	{
	}
}
