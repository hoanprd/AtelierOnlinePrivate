using UnityEngine;

public class Sound_Music : MonoBehaviour
{
	public enum eMusicStep
	{
		Initialize = 0,
		RequestWait = 1,
		LoopPart = 2,
		FadeOut = 3
	}

	private static readonly float sc_fWaitSec_FadeOut;

	private AudioClip m_acReq_LoopPart;

	private bool m_bReq_LoopFlag;

	private float m_fFadeSec_Now;

	private float m_fFadeSec_Max;

	private bool m_bFadeReqFlag;

	private float m_fSample;

	private float m_fVolume_Percent;

	private eMusicStep m_eMainStep;

	private AudioSource m_asAudio;

	private void Initialize()
	{
	}

	private void Update()
	{
	}

	public bool IsOK_MusicReq()
	{
		return false;
	}

	public void PlayStart(AudioClip acLoop, bool bLoop, float sample)
	{
	}

	private void LoopMusic()
	{
	}

	private bool IsPlayEnd()
	{
		return false;
	}

	public void SetFadeout()
	{
	}

	public void Stop()
	{
	}

	public float GetTime()
	{
		return 0f;
	}

	private void SetVolume_Percent(float fPercent)
	{
	}

	public void UpdateVolume()
	{
	}

	private eMusicStep RepairLeakRequest(eMusicStep eStep)
	{
		return eMusicStep.Initialize;
	}
}
