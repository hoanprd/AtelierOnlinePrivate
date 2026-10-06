using UnityEngine;

public class Game_Animal_Normal : Game_Animal_BaseFader
{
	private Animator m_targetAnimator;

	public float m_addPos_Scale;

	protected float m_addPosZ_Now;

	protected float m_rotationY;

	public float m_waitSec_Min;

	public float m_waitSec_Max;

	private float m_waitSec_Now;

	public float m_stopPercent;

	public float m_addPosZ_Min;

	public float m_addPosZ_Max;

	public float m_addRotY_Max;

	private float m_addPosZ_Log;

	private float m_addRotY_Log;

	public override void InitializeAnimal()
	{
	}

	protected override void AnimalUpdate_Always()
	{
	}
}
