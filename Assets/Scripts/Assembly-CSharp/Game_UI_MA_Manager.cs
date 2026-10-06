using System;
using UnityEngine;

public class Game_UI_MA_Manager : MonoBehaviour
{
	private static Game_UI_MA_Manager g_scrInst;

	[SerializeField]
	private AnimationController m_inoutAnim;

	[SerializeField]
	private GameObject m_raderCamera;

	[SerializeField]
	private GameObject m_clock;

	[SerializeField]
	private GameObject m_questButton;

	[SerializeField]
	private GameObject m_freeAlterButton;

	[SerializeField]
	private GameObject m_dungeonNamePreafab;

	[SerializeField]
	private GameObject m_questSelectPrefab;

	[SerializeField]
	private GameObject m_areaNamePreafab;

	private bool m_suspendInAnim;

	private bool m_suspendOutAnim;

	public SpawnPrefabData m_sDeliveryPrefab;

	public GameObject m_gateButton;

	public GameObject m_questRetireButton;

	public Game_UI_GotItemBalloon m_gotItemBaloon;

	public Game_UI_AutoMoveIcon m_autoMoveIcon;

	public Game_UI_BombMarkIcon m_bombMarkIcon;

	public Game_UI_FieldLauncher m_launcher;

	public GameObject m_overHeadRoot;

	public DungeonFloorMoveDialog m_dungeonFloorDialog;

	public Game_UI_OnlineQuest_Button m_multiQuestButton;

	public Game_UI_ActionShortcutManager m_actionShortcutManager;

	public TargetArrowManager m_targetArrow;

	public BattleJoinDialog battleJoinDialog;

	[NonSerialized]
	public AreaNameText m_dungeonName;

	[NonSerialized]
	public QuestSelectWindow m_questSelect;

	[NonSerialized]
	public AreaNameText m_areaName;

	private GameObject m_currentUIObj_Log;

	public static Game_UI_MA_Manager GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Bringin()
	{
	}

	public void Dismiss(bool Immediate = false)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEndDismiss()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void UpdateUIActive()
	{
	}

	public void SetEnableCurrentUI(GameObject obj)
	{
	}

	public bool IsEnableCurrentUI()
	{
		return false;
	}

	public static bool IsAutoPick()
	{
		return false;
	}

	public static void StopAutoPick()
	{
	}

	public static void AutoPickUseBomb(bool bUse)
	{
	}

	public static void setMiniRankingScore(int score)
	{
	}

	public static void ActivateMapButton(bool active)
	{
	}

	public static void ActivateQuestRetireButton(bool active)
	{
	}
}
