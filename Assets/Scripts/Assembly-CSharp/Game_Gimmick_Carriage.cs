using UnityEngine;
using UnityEngine.AI;

public class Game_Gimmick_Carriage : Game_Gimmick_Base
{
	private Game_Item_PickUp_Base m_scrItem;

	private int m_iCarriageId;

	private bool m_bHit;

	public Vector3 m_v3Target;

	public NavMeshAgent m_scrAgent;

	public Animator m_scrAnimator;

	protected override void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnHitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	private void OnEnd()
	{
	}

	public void SetInfo(Game_Item_PickUp_Base scrItem, Vector3 v3Target, int iId)
	{
	}

	public void Appear()
	{
	}

	public override bool IsImmediate()
	{
		return false;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}
}
