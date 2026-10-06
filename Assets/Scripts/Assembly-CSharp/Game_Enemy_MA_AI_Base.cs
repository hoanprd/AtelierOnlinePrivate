using UnityEngine;

public class Game_Enemy_MA_AI_Base
{
	protected static readonly float sr_fDisableTime;

	protected static readonly float sr_fChaseUpdateSec;

	protected static readonly float sr_fFreeMoveDiff;

	protected Transform m_trEnemy;

	protected Game_Enemy_MA_MultiPlay m_scrLocalEnemy;

	protected Vector3 m_v3FMoveTarget;

	protected EnemyInfo m_clsEnemyInfo;

	protected bool m_bLocal;

	protected MultiPlay_CharaData m_clsTargetChara;

	protected float m_fWaitTime;

	protected int m_iEnemyLv;

	public virtual void Init(Transform trEnemy, Game_Enemy_MA_MultiPlay scrEnemy, EnemyInfo clsInfo, int iEnemyLv)
	{
	}

	public bool IsInit()
	{
		return false;
	}

	public virtual eFEnemyAIState UpdateAI(eFEnemyAIState eNow, bool bLocal, bool bStop, bool bDisp)
	{
		return eFEnemyAIState.Init;
	}

	protected virtual eFEnemyAIState AI_Init()
	{
		return eFEnemyAIState.Init;
	}

	protected virtual eFEnemyAIState AI_Wait()
	{
		return eFEnemyAIState.Init;
	}

	protected virtual eFEnemyAIState AI_FreeMove()
	{
		return eFEnemyAIState.Init;
	}

	protected virtual eFEnemyAIState AI_ChaseMove()
	{
		return eFEnemyAIState.Init;
	}

	protected virtual eFEnemyAIState AI_Discovery()
	{
		return eFEnemyAIState.Init;
	}

	protected virtual eFEnemyAIState AI_LoseTrack()
	{
		return eFEnemyAIState.Init;
	}

	protected virtual eFEnemyAIState AI_Escape()
	{
		return eFEnemyAIState.Init;
	}

	protected virtual eFEnemyAIState AI_Disable()
	{
		return eFEnemyAIState.Init;
	}

	protected virtual void ChangeAI_Init()
	{
	}

	protected virtual void ChangeAI_Wait()
	{
	}

	protected virtual void ChangeAI_FreeMove()
	{
	}

	protected virtual void ChangeAI_ChaseMove()
	{
	}

	protected virtual void ChangeAI_Discovery()
	{
	}

	protected virtual void ChangeAI_LoseTrack()
	{
	}

	protected virtual void ChangeAI_Escape()
	{
	}

	protected virtual void ChangeAI_Disable()
	{
	}

	protected virtual MultiPlay_CharaData GetFieldCharaData(bool bLvCheck = true)
	{
		return null;
	}

	protected virtual bool IsExistCharaInside()
	{
		return false;
	}

	protected Quaternion GetRotation(Vector3 v3MoveVec)
	{
		return default(Quaternion);
	}

	protected bool IsOverVector(Vector3 v3Vector, float fDist)
	{
		return false;
	}

	protected void SetAnimation(BattleCharaData.eActionKind eAction)
	{
	}

	protected Vector3 GetMakePos()
	{
		return default(Vector3);
	}

	protected void SetDrawEnable(bool bEnable)
	{
	}

	protected void StopAgent()
	{
	}
}
