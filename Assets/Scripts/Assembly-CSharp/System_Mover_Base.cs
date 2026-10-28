using UnityEngine;

public class System_Mover_Base : MonoBehaviour
{
	private static bool m_bMoveOKFlag = true;

	private bool m_bAnimeStopFlag_Log;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public static void SetMoveOKFlag(bool bFlag)
	{
		m_bMoveOKFlag = bFlag;
	}

	protected virtual void Update()
	{
		bool pauseAnime = IsPause_Anime();
		if (m_bAnimeStopFlag_Log != pauseAnime)
		{
			m_bAnimeStopFlag_Log = pauseAnime;
			SetAnimationFlag(pauseAnime);
		}
		if (IsPause_Move())
		{
			MoverUpdate_Pause();
		}
		else
		{
			MoverUpdate_Normal();
		}
	}

	protected virtual bool IsPause_Move()
	{
		return !m_bMoveOKFlag;
	}

	protected virtual bool IsPause_Anime()
	{
		return !m_bMoveOKFlag;
	}

	protected virtual void MoverUpdate_Normal()
	{
	}

	protected virtual void MoverUpdate_Pause()
	{
	}

	protected void SetAnimationFlag(bool bStop)
	{
		SetAnimationFlag_All(bStop);
	}

	protected virtual void SetAnimationFlag_All(bool bStop)
	{
		SetAnimationFlag_Model(gameObject, bStop);
		SetAnimationFlag_Particle(gameObject, bStop);
	}

	protected void SetAnimationFlag_Model(GameObject goTarget, bool bStop)
	{
		if (goTarget == null)
		{
			return;
		}
		Animator[] animators = goTarget.GetComponentsInChildren<Animator>(true);
		float spd = bStop ? 0f : GetGlobalAnimationSpeed();
		for (int i = 0; i < animators.Length; i++)
		{
			if (animators[i] != null)
			{
				animators[i].speed = spd;
			}
		}
	}

	protected void SetAnimationFlag_Particle(GameObject goTarget, bool bStop)
	{
		if (goTarget == null)
		{
			return;
		}
		ParticleSystem[] particles = goTarget.GetComponentsInChildren<ParticleSystem>(true);
		for (int i = 0; i < particles.Length; i++)
		{
			if (particles[i] != null)
			{
				if (bStop)
				{
					particles[i].Pause(true);
				}
				else if (particles[i].isPaused)
				{
					particles[i].Play(true);
				}
			}
		}
	}

	protected float GetDeltaTime()
	{
		return System_TimeManager.GetDeltaTime();
	}

	protected float GetDeltaTime_Real()
	{
		return Time.unscaledDeltaTime;
	}

	protected float GetGlobalTimeScale()
	{
		return System_TimeManager.GetMoverTimeScale();
	}

	protected float GetGlobalAnimationSpeed()
	{
		return System_TimeManager.GetAnimationTimeScale();
	}
}
