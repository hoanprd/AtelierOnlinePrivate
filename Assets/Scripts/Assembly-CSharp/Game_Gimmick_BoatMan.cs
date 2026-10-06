using UnityEngine;

public class Game_Gimmick_BoatMan : Game_Gimmick_Base
{
	public enum eMyStep
	{
		Wait = 0,
		Row_Init = 1,
		Row_Wait = 2,
		Rest = 3
	}

	public enum eState
	{
		None = 0,
		Wait = 1,
		Rest = 2
	}

	public enum eBoatEff
	{
		Wait = 0,
		Row = 1,
		EnumMax = 2
	}

	private static readonly eEffectKind[] sr_eEffectAry;

	private eMyStep m_eStep;

	private float m_fRowWait;

	private float m_fWaitTime;

	private bool m_bRow;

	private Vector3 m_v3OrgPos;

	private Vector3 m_v3NPCOrgPos;

	private Quaternion m_qBoatOrgRot;

	private float m_fNPCOrgRotY;

	private bool m_bApproach;

	private float m_fMoveSpeed;

	private float m_fAmplitude;

	private float m_fTime;

	private float m_fCycle;

	private Vector3 m_v3Forward;

	private float m_fEndRestDist;

	private GameObject[] m_goBoatEffectAry;

	[SerializeField]
	private Vector3 m_v3OrgForward;

	[SerializeField]
	private GameObject m_goShip;

	[SerializeField]
	private GameObject m_goBoatmanRowPos;

	[SerializeField]
	private Game_Chara_MA_NPC m_scrNPC;

	[SerializeField]
	private GameObject m_goPlayerBoatPos;

	[SerializeField]
	private GameObject m_goPlayerGetOffPos;

	[SerializeField]
	private MapAreaFixedArrow m_scrArrow;

	private bool m_bArrowActive;

	public bool m_bAreaChange;

	public static Game_Gimmick_BoatMan s_Instance { get; private set; }

	protected override void Start()
	{
	}

	private void MakeNPC()
	{
	}

	private void LoadEffect()
	{
	}

	private void ChangeBoatEffect(eBoatEff eEffect)
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void MoverUpdate_Pause()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	private void BoatQuake(bool bHalf)
	{
	}

	public void SetForward(Vector3 v3Forward)
	{
	}

	public void SetPos_Org()
	{
	}

	public void SetRow()
	{
	}

	public void SetNPCPos_Org()
	{
	}

	public void SetNPCPos(Vector3 v3Forward)
	{
	}

	public void SetBoatRot_Org()
	{
	}

	public void SetBoatRot(Vector3 v3Forward)
	{
	}

	public Vector3 GetPlayerPos(bool bBoat)
	{
		return default(Vector3);
	}

	public Vector3 GetOrgForward()
	{
		return default(Vector3);
	}

	public Quaternion GetRot(Vector3 v3Forward)
	{
		return default(Quaternion);
	}

	public float GetRotY(Vector3 v3Forward)
	{
		return 0f;
	}

	public GameObject GetShip()
	{
		return null;
	}

	public Game_Chara_MA_NPC GetNPC()
	{
		return null;
	}

	public eState GetState()
	{
		return eState.None;
	}

	public void SetPos(Vector3 v3PlayerPos)
	{
	}

	public void SetApproach()
	{
	}

	public bool IsApproach()
	{
		return false;
	}

	public override EGimmickKind GetKind()
	{
		return EGimmickKind.eNONE;
	}

	public void SetActiveArrow(bool bActive)
	{
	}
}
