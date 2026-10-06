using UnityEngine;

public class System_Mover_Base : MonoBehaviour
{
	private static bool m_bMoveOKFlag;

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
	}

	protected virtual void Update()
	{
	}

	protected virtual bool IsPause_Move()
	{
		return false;
	}

	protected virtual bool IsPause_Anime()
	{
		return false;
	}

	protected virtual void MoverUpdate_Normal()
	{
	}

	protected virtual void MoverUpdate_Pause()
	{
	}

	protected void SetAnimationFlag(bool bStop)
	{
	}

	protected virtual void SetAnimationFlag_All(bool bStop)
	{
	}

	protected void SetAnimationFlag_Model(GameObject goTarget, bool bStop)
	{
	}

	protected void SetAnimationFlag_Particle(GameObject goTarget, bool bStop)
	{
	}

	protected float GetDeltaTime()
	{
		return 0f;
	}

	protected float GetDeltaTime_Real()
	{
		return 0f;
	}

	protected float GetGlobalTimeScale()
	{
		return 0f;
	}

	protected float GetGlobalAnimationSpeed()
	{
		return 0f;
	}
}
