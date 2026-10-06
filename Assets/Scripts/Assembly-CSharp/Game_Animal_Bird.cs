using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class Game_Animal_Bird : Game_Animal_ItemDrop
{
	protected float m_rotationY;

	protected float m_waitSec_Now;

	protected float m_dist_Escape;

	protected float m_addRotY_Max;

	protected float m_rotY_Origin;

	protected Coroutine m_rotateCoroutine;

	protected override float m_dist_Appear
	{
		get
		{
			return 0f;
		}
	}

	protected virtual float m_waitSec_Min
	{
		get
		{
			return 0f;
		}
	}

	protected virtual float m_waitSec_Max
	{
		get
		{
			return 0f;
		}
	}

	public override void InitializeAnimal()
	{
	}

	protected override void MoveOK_Init()
	{
	}

	protected override void MoveOK_Wait()
	{
	}

	protected virtual void RandomRotate()
	{
	}

	protected virtual void MoveOKWait_Animator()
	{
	}

	protected override void MoveNG_Init()
	{
	}

	protected override bool IsMoveOKtoNG()
	{
		return false;
	}

	protected override bool IsMoveNGtoOK()
	{
		return false;
	}

	protected virtual void OnTouched()
	{
	}

	protected override float GetFadePercent(bool forward, float percentNow)
	{
		return 0f;
	}

	protected virtual void PlaySE_Escape()
	{
	}

	public Vector3 GetRotation()
	{
		return default(Vector3);
	}

	public float GetRotation(Vector3 from, Vector3 target)
	{
		return 0f;
	}

	public void StartRotate(float rotY, float rotTime = 0.2f)
	{
	}

	public virtual void StartRotate(Vector3 target, float rotTime = 0.2f)
	{
	}

	[DebuggerHidden]
	public IEnumerator Rotate(Vector3 target, float rotTime = 0.2f)
	{
		return null;
	}

	public bool IsEndRotate()
	{
		return false;
	}
}
