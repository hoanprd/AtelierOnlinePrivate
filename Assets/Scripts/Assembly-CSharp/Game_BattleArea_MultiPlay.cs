using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Game_BattleArea_MultiPlay : Game_BattleArea_Base
{
	private enum ELoadABKind
	{
		eCinema = 0,
		eMax = 1
	}

	private AssetLoader[] m_assetLoadList;

	public Transform[] PositionListPlayer;

	public Transform[] PositionListEnemy;

	public static Game_BattleArea_MultiPlay SharedInstance;

	private new MultiPlay_BattleData m_battleData;

	private Dictionary<int, MultiPlay_BattleMemberData> m_charaPosList;

	private Dictionary<int, MultiPlay_BattleMemberData> m_enemyPosList;

	private CinemaManager m_cinema;

	private int m_cinemaCount;

	private bool m_isBattleLog;

	private bool m_isContinue;

	private List<GameObject> m_objectList;

	private GameObject m_dialog;

	private int m_localBattleTurn;

	private int m_turn;

	private bool m_pause;

	private bool m_firstDialogFlag;

	private float m_turnWaitTime;

	private AssetDownloader m_loader;

	private BattleFinish m_resultInfo;

	private InventoryList m_getInventoryInfo;

	private List<APIBattleFinish.Request.UseSkill> m_useSkillList;

	private bool m_gettingRanking;

	public bool m_debaguskillflag;

	public int m_debaguskillenemyIndex;

	public int m_debaguskillcount;

	public List<int> m_debaguskilllist;

	public static MultiPlay_BattleData BattleData
	{
		get
		{
			return null;
		}
	}

	protected override void Battle_Initialize()
	{
	}

	protected override void SetCharacterObj()
	{
	}

	private int SearchFreeIndex(MultiPlay_BattleMemberData member, bool isJoin = false)
	{
		return 0;
	}

	public void RemoveMemberIndex(int index)
	{
	}

	private void RemoveIndex()
	{
	}

	public Vector3 GetBattlePosition(MultiPlay_BattleMemberData data)
	{
		return default(Vector3);
	}

	public Quaternion GetBattleRotation(MultiPlay_BattleMemberData data)
	{
		return default(Quaternion);
	}

	private void CreateMember(MultiPlay_BattleMemberData data, bool isJoin = false)
	{
	}

	[DebuggerHidden]
	private IEnumerator MakeCharaObject(MakeCharaData makeChara, MultiPlay_BattleMemberData data, Game_Chara_BA_Base tempChara, GameObject tempObj)
	{
		return null;
	}

	protected override void MoverUpdate_Normal()
	{
	}

	public void PlayBGM()
	{
	}

	protected override void Battle_Update()
	{
	}

	[DebuggerHidden]
	private IEnumerator GetRankingCoroutine()
	{
		return null;
	}

	public bool IsLoadCinemaAssets()
	{
		return false;
	}

	public void SkillStart(MultiPlay_BattleMemberData member)
	{
	}

	public void DisplayOff()
	{
	}

	public void DisplayOn()
	{
	}

	public void CinemaFinish()
	{
	}

	private void CinemaSetRegisterPlayerMember()
	{
	}

	[DebuggerHidden]
	private IEnumerator PlayBattleLog(string battleLog)
	{
		return null;
	}

	private bool CommandJoinEnemy0()
	{
		return false;
	}

	private void CommandJoinEnemy1(string command)
	{
	}

	private void CommandJoinMember0(string command)
	{
	}

	private void CommandJoinMember1(string command)
	{
	}

	private void CommandJoinNPC0(string command)
	{
	}

	private void CommandJoinNPC1(string command1, string command2)
	{
	}

	[DebuggerHidden]
	private IEnumerator ReqBattleFinish()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator ReqBattleEscape()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator ContinueScene()
	{
		return null;
	}

	private void OnWaitContinue(EButtonKind result)
	{
	}

	public void Continue(bool flag, int df)
	{
	}

	public void ExtraRetire(bool ishost)
	{
	}

	public void ExtraWithdrawalJoin(int charaID, bool isHost)
	{
	}

	public bool IsContinueWait()
	{
		return false;
	}

	public void ExqContinueWidClose()
	{
	}

	public void ExqForceLastInit()
	{
	}

	public void WithdrawalJoin(int charaID)
	{
	}

	[DebuggerHidden]
	private IEnumerator StartCutIn()
	{
		return null;
	}

	public void SetActionMember(MultiPlay_BattleMemberData member)
	{
	}

	public void BattleMemberSteal(MultiPlay_BattleMemberData action, MultiPlay_BattleMemberData target)
	{
	}

	public void BattleMemberDead(MultiPlay_BattleMemberData target)
	{
	}

	[DebuggerHidden]
	private IEnumerator EnemyDead(MultiPlay_BattleMemberData target)
	{
		return null;
	}

	public void CharaAdvIcon(int charaID, bool drawFlag, EEmoticon emote, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.BattleArea)
	{
	}

	public void EnemyAdvIcon(int enemyArrayID, bool drawFlag, EEmoticon emote, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.BattleArea)
	{
	}

	public GameObject CharaModel(int charaID)
	{
		return null;
	}

	public GameObject EnemyModel(int enemyArrayID)
	{
		return null;
	}

	public void BattleMemberSetIdle(MultiPlay_BattleMemberData member, bool bQueued = false)
	{
	}

	public int GetMySkillCount()
	{
		return 0;
	}

	public int GetMySkillChainCount()
	{
		return 0;
	}

	public void Debug_Update()
	{
	}

	public void Debug_StateChange(EAbnormalState state)
	{
	}
}
