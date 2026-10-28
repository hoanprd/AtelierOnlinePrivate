using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sound_Music : MonoBehaviour
{
	public enum eMusicStep
	{
		Initialize = 0,
		RequestWait = 1,
		LoopPart = 2,
		FadeOut = 3
	}

	private static readonly float sc_fWaitSec_FadeOut = 0.5f;

	private AudioClip m_acReq_LoopPart;

	private bool m_bReq_LoopFlag;

	private float m_fFadeSec_Now;

	private float m_fFadeSec_Max = 1f;

	private bool m_bFadeReqFlag;

	private float m_fSample;

	private float m_fVolume_Percent;

	private eMusicStep m_eMainStep;

	private AudioSource m_asAudio;

	private void Initialize()
	{
		m_asAudio = GetComponent<AudioSource>();
		if (m_asAudio == null)
		{
			m_asAudio = gameObject.AddComponent<AudioSource>();
		}
		Stop();
		m_acReq_LoopPart = null;
		m_bReq_LoopFlag = false;
	}

	private void Update()
	{
		eMusicStep nextStep = m_eMainStep;
		switch (m_eMainStep)
		{
		case eMusicStep.Initialize:
			Initialize();
			nextStep = eMusicStep.RequestWait;
			break;
		case eMusicStep.RequestWait:
			if (m_acReq_LoopPart != null)
			{
				LoopMusic();
				m_bFadeReqFlag = false;
				nextStep = eMusicStep.LoopPart;
			}
			break;
		case eMusicStep.LoopPart:
		{
			float dt = Time.deltaTime;
			float maxFade = Mathf.Max(0.01f, m_fFadeSec_Max);
			m_fFadeSec_Now = Mathf.Clamp(m_fFadeSec_Now + dt * 2f, 0f, maxFade);
			m_fVolume_Percent = m_fFadeSec_Now / maxFade;
			UpdateVolume();
			eMusicStep candidate = m_bFadeReqFlag ? eMusicStep.FadeOut : eMusicStep.LoopPart;
			nextStep = RepairLeakRequest(candidate);
			break;
		}
		case eMusicStep.FadeOut:
		{
			float dt2 = Time.deltaTime;
			float maxFade2 = Mathf.Max(0.01f, m_fFadeSec_Max);
			m_fFadeSec_Now = Mathf.Clamp(m_fFadeSec_Now - dt2, 0f, maxFade2);
			m_fVolume_Percent = m_fFadeSec_Now / maxFade2;
			UpdateVolume();
			if (m_fFadeSec_Now <= 0f)
			{
				Stop();
				nextStep = eMusicStep.RequestWait;
			}
			break;
		}
		}
		if (m_eMainStep != nextStep)
		{
			m_eMainStep = nextStep;
		}
	}

	public bool IsOK_MusicReq()
	{
		return m_acReq_LoopPart == null;
	}

	public void PlayStart(AudioClip acLoop, bool bLoop, float sample)
	{
		if (m_asAudio == null)
		{
			m_asAudio = GetComponent<AudioSource>();
			if (m_asAudio == null)
			{
				m_asAudio = gameObject.AddComponent<AudioSource>();
			}
		}
		if (m_acReq_LoopPart != null)
		{
			Debug.LogWarning("BGM 二重登録？");
		}
		m_acReq_LoopPart = acLoop;
		m_bReq_LoopFlag = bLoop;
		m_fSample = sample;
	}

	private void LoopMusic()
	{
		if (m_asAudio == null)
		{
			Initialize();
		}
		m_asAudio.clip = m_acReq_LoopPart;
		m_asAudio.loop = m_bReq_LoopFlag;
		if (m_acReq_LoopPart != null && m_fSample >= 0f && m_fSample < m_acReq_LoopPart.length)
		{
			m_asAudio.time = m_fSample;
		}
		else
		{
			m_asAudio.time = 0f;
		}
		m_asAudio.Play();
		m_fFadeSec_Now = 0f;
		m_fFadeSec_Max = 1f;
		m_acReq_LoopPart = null;
		m_bReq_LoopFlag = false;
	}

	private bool IsPlayEnd()
	{
		return m_asAudio == null || !m_asAudio.isPlaying;
	}

	public void SetFadeout()
	{
		m_bFadeReqFlag = true;
		m_fFadeSec_Max = sc_fWaitSec_FadeOut;
		m_fFadeSec_Now = sc_fWaitSec_FadeOut;
	}

	public void Stop()
	{
		if (m_asAudio != null)
		{
			m_asAudio.Stop();
		}
		m_fVolume_Percent = 0f;
		UpdateVolume();
	}

	public float GetTime()
	{
		if (m_asAudio == null)
		{
			return 0f;
		}
		return m_asAudio.time;
	}

	private void SetVolume_Percent(float fPercent)
	{
		m_fVolume_Percent = fPercent;
		UpdateVolume();
	}

	public void UpdateVolume()
	{
		if (m_asAudio == null)
		{
			return;
		}
		float optVol = System_GlobalValue.GetUserInfo().stOptionData.GetSound_Volume(DB_OptionData.eSoundKind.Music);
		float clamped = Mathf.Clamp01(m_fVolume_Percent * optVol);
		m_asAudio.volume = clamped * Sound_Manager.BGMVolume;
	}

	private eMusicStep RepairLeakRequest(eMusicStep eStep)
	{
		if (m_acReq_LoopPart != null && m_eMainStep == eMusicStep.LoopPart)
		{
			return eMusicStep.RequestWait;
		}
		return eStep;
	}
}
