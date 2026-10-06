using UnityEngine;

public class Game_Gimmick_Ship : Game_Gimmick_Base
{
	private bool m_bRideOn;

	private float m_fOriginalY;

	[SerializeField]
	private float m_fAmplitude;

	[SerializeField]
	private float m_fTime;

	[SerializeField]
	private float m_fCycle;

	[SerializeField]
	private float m_fMoveSpeed;

	protected override void Start()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public override bool IsEnable()
	{
		return false;
	}

	public void RideOn()
	{
	}
}
