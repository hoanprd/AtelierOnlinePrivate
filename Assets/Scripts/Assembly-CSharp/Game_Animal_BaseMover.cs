using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Game_Animal_BaseMover : Game_Animal_BaseFader
{
	protected Animator m_targetAnimator;

	protected Transform m_fadeOffsetRoot;

	protected Vector3 m_fadeOffsetDir;

	protected Vector3 m_fadeOutPos;

	protected float m_fadeMoveSpeedScale;

	private float m_fadeWaitSec_Now;

	protected float m_fadeWaitSec_Max;

	protected bool m_moveIO_Flag;

	protected Collider m_physicsCollision;

	protected Rigidbody m_physicsRigidbody;

	protected NavMeshAgent m_agent;

	public void SetMoveIO(bool flag)
	{
	}

	public override void InitializeAnimal()
	{
	}

	protected virtual List<Transform> GetOffsetChildList()
	{
		return null;
	}

	protected override void MoveOK_Init()
	{
	}

	protected override void MoveNG_Init()
	{
	}

	protected override bool MoveOK_Fade()
	{
		return false;
	}

	protected override bool MoveNG_Fade()
	{
		return false;
	}

	protected override void AnimalUpdate_Fade(bool forward, float percentNow)
	{
	}

	protected virtual float GetFadePercent(bool forward, float percentNow)
	{
		return 0f;
	}

	protected override void SetAnimalDrawSub(bool enableDrawNow)
	{
	}

	public virtual void SetAgent()
	{
	}

	public void SetEnableAgent(bool enable)
	{
	}
}
