using UnityEngine;

public class Game_MA_MazeHintColl : Game_MA_HitColl_Base
{
	private static readonly Vector3 sr_v3InitPos;

	private bool m_bMoveFlag;

	private Vector3 m_v3MoveVecNow;

	private GameObject m_goEffect;

	private bool m_bEnable;

	public int m_iCollId;

	public float m_fMoveTime;

	public Vector3[] m_v3MoveVecAry;

	protected override void Awake()
	{
	}

	protected override void OnTriggerEnter(Collider scrCol)
	{
	}

	protected override void HitPlayer(Game_Chara_MA_Player scrPlayer)
	{
	}

	private void OnFinishedTween()
	{
	}

	private void HitHint()
	{
	}

	public void SetMovePos(Vector3 v3Pos)
	{
	}

	public void SetEnable(bool bEnable)
	{
	}
}
