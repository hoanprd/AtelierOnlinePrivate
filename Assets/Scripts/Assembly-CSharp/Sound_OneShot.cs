using UnityEngine;

public class Sound_OneShot : System_Mover_Base
{
	public static float s_fEnvSeScale = 1f;

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
			return m_bEnvSe;
		}
		set
		{
			m_bEnvSe = value;
		}
	}

	public void Initialize()
	{
		m_asTargetSource = gameObject.GetComponent<AudioSource>();
		if (m_asTargetSource != null)
		{
			m_asTargetSource.volume = Sound_Manager.SEVolume;
		}
	}

	protected override void MoverUpdate_Pause()
	{
		if (m_bIgnorePause)
		{
			MoverUpdate_Normal();
		}
	}

	protected override void MoverUpdate_Normal()
	{
		if (m_asTargetSource == null)
		{
			Object.Destroy(gameObject);
			return;
		}
		if (!m_bStartedFlag)
		{
			m_fWaitSec_Start -= GetDeltaTime_Real();
			if (m_fWaitSec_Start <= 0f)
			{
				if (m_bTimeScale)
				{
					m_asTargetSource.pitch = System_TimeManager.GetTimeScale();
				}
				CheckVolume();
				m_asTargetSource.Play();
				m_bStartedFlag = true;
			}
		}
		else
		{
			CheckVolume();
			if (!m_asTargetSource.isPlaying)
			{
				Object.Destroy(gameObject);
			}
		}
	}

	protected void CheckVolume()
	{
		if (m_goSpeakerObj != null && m_goListenerObj != null)
		{
			SetVolume(GetVolumePercent());
			if (m_bTimeScale && m_asTargetSource != null)
			{
				m_asTargetSource.pitch = System_TimeManager.GetMoverTimeScale();
			}
		}
	}

	public void UpdateVolume()
	{
		if (m_goSpeakerObj != null && m_goListenerObj != null)
		{
			CheckVolume();
			return;
		}
		SetVolume(1f);
		if (m_bTimeScale && m_asTargetSource != null)
		{
			m_asTargetSource.pitch = System_TimeManager.GetMoverTimeScale();
		}
	}

	public void SetVolume(float volNow)
	{
		if (m_asTargetSource == null)
		{
			return;
		}
		float optVol = System_GlobalValue.GetUserInfo().stOptionData.GetSound_Volume(DB_OptionData.eSoundKind.Sound);
		float vol = Sound_Manager.SEVolume * optVol * volNow;
		if (m_bEnvSe)
		{
			vol *= s_fEnvSeScale;
		}
		m_asTargetSource.volume = vol;
	}

	public float GetVolumePercent()
	{
		if (m_goSpeakerObj == null || m_goListenerObj == null)
		{
			return 0f;
		}
		float dist = Vector3.Distance(m_goSpeakerObj.transform.position, m_goListenerObj.transform.position);
		float span = m_fVolumeDist_Far - m_fVolumeDist_Near;
		if (span >= 0.01f)
		{
			float clamped = Mathf.Clamp(dist, m_fVolumeDist_Near, m_fVolumeDist_Far);
			return 1f - Mathf.Clamp01((clamped - m_fVolumeDist_Near) / span);
		}
		return (dist <= m_fVolumeDist_Near) ? 1f : 0f;
	}

	public void SetPlayTiming(float fWaitSec)
	{
		m_fWaitSec_Start = fWaitSec;
		m_bStartedFlag = false;
	}

	public void SetDistanceVolume(GameObject speaker, GameObject listener, float near, float far, LocalLine[] lines = null)
	{
		m_goSpeakerObj = speaker;
		m_goListenerObj = listener;
		m_fVolumeDist_Near = near;
		m_fVolumeDist_Far = far;
		m_cLines = lines;
		SetVolume(0f);
	}

	public void SetTimeScale(bool sw)
	{
		m_bTimeScale = sw;
	}

	public void SetReverb(bool enableFlag)
	{
		m_bReverbFlag = enableFlag;
		AudioReverbFilter reverb = gameObject.GetComponent<AudioReverbFilter>();
		if (reverb != null)
		{
			reverb.enabled = enableFlag;
		}
		AudioEchoFilter echo = gameObject.GetComponent<AudioEchoFilter>();
		if (echo != null)
		{
			echo.enabled = enableFlag;
		}
	}
}
