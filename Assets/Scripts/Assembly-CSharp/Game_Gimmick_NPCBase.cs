using UnityEngine;

public class Game_Gimmick_NPCBase : Game_Gimmick_Base
{
	private Vector3 m_vDefaultRotation;

	protected Game_Chara_MA_NPC m_sNPC;

	protected Game_Animal_BaseFader m_myAnimalBase;

	protected Game_UI_Talk m_sTalk;

	protected ADVMoveObj m_sMove;

	protected eFieldNPC m_eNPCKind;

	public int m_iQuestId;

	public override void SetSpotNo(int no)
	{
	}

	protected virtual void Regist(int no)
	{
	}

	protected virtual void Release()
	{
	}

	protected override void OnDestroy()
	{
	}

	public Vector3 GetDefaultRotation()
	{
		return default(Vector3);
	}

	public Game_Chara_MA_NPC GetNPC()
	{
		return null;
	}

	public void SetQuestID(int questId)
	{
	}

	public virtual int GetQuestID()
	{
		return 0;
	}

	public void Init(eFieldNPC eKind, bool[] moveTimeArray, bool[] moveWeatherArray)
	{
	}

	public static MakeCharaData GetPartyMakeCharaData(int npcID)
	{
		return null;
	}

	public static MakeCharaData GetMakeCharaData(int npcID, bool bDefault = false)
	{
		return null;
	}

	public virtual void SetNPC(int npcID, bool bTalk = true, bool bDefault = false)
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

	public virtual void Kill()
	{
	}

	protected void OnWalk()
	{
	}

	protected void OnDash()
	{
	}

	protected void OnEnd()
	{
	}

	public void SetAutoMove(Vector3 target, float speed, bool useNavmesh, bool firstFull, bool endFull, bool rotate)
	{
	}

	public bool IsAutoMoveEnd()
	{
		return false;
	}

	public void ForceEndMove()
	{
	}

	public void SetCullingEnable(bool bEnable)
	{
	}

	public void SetDrawFadeEnable(bool bEnable)
	{
	}
}
