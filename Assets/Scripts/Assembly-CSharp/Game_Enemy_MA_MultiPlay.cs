using System;
using UnityEngine;
using UnityEngine.AI;

public class Game_Enemy_MA_MultiPlay : Game_Enemy_FieldBase
{
	private static readonly Color32 m_strongColor;

	private Vector3 m_makePosition;

	private EnemyInfo m_enemyInfo;

	private Game_Enemy_MA_AI_Base m_AIScr;

	private Game_UI_MA_EnemyInfo m_info;

	private bool m_bDiscoveryIcon;

	private GameObject m_raderMarker;

	private bool m_drawUI_Log;

	private bool m_drawRader_Log;

	private bool m_fake_Log;

	private bool m_drawFlag_AI;

	public NavMeshAgent NavMeshAgent
	{
		get
		{
			return null;
		}
	}

	public void EnableAura()
	{
	}

	public void DisableAura()
	{
	}

	protected override void Awake()
	{
	}

	protected override void MakeAfter_F()
	{
	}

	public override void SetData_F(long enemyId, int df, int moveTime, int moveWeather, eFEnemyAIType ai, eFakeEnemy fake, bool isRandom, int level, int auraSize, Action<GameObject> makeCallback)
	{
	}

	public void UpdateInfo(MultiPlay_EnemyData data)
	{
	}

	private void SetDrawUI(bool isDraw)
	{
	}

	private void SetDrawRader(bool isDraw)
	{
	}

	public void UpdateFromAI(MultiPlay_EnemyData data)
	{
	}

	private void UpdateNameInfo(MultiPlay_EnemyData data)
	{
	}

	private void UpdateAIState(MultiPlay_EnemyData data)
	{
	}

	private void UpdateAgentEnable(MultiPlay_EnemyData data)
	{
	}

	public void UpdateFromSync(MultiPlay_EnemyData data)
	{
	}

	public bool IsDrawOK(bool checkCulling = false)
	{
		return false;
	}

	public bool IsMoveTime()
	{
		return false;
	}

	public void SetActive_Battle(bool active)
	{
	}

	private bool IsDiscovery(MultiPlay_EnemyData data)
	{
		return false;
	}

	private void SetDiscoveryIcon(bool bDisp)
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	public override void SetFake(bool flag)
	{
	}

	public Vector3 GetMakePos()
	{
		return default(Vector3);
	}

	public void SetDrawEnable(bool enable)
	{
	}

	public void SetDrawEnable_AI(bool enable)
	{
	}

	public EnemyInfo GetEnemyInfo()
	{
		return null;
	}
}
