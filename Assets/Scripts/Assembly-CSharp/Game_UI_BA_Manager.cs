using UnityEngine;

public class Game_UI_BA_Manager : MonoBehaviour
{
	private static Game_UI_BA_Manager g_scrInst;

	public Camera m_nguiCamera;

	public Game_UI_LifeGauge_Manager m_lifeGaugeManager;

	public Game_UI_DamageNumber_Spawner m_damageNumSpawner;

	public Game_UI_SkillName m_skillNameScr;

	public Game_UI_SkillName m_skillNameEnemyScr;

	public Game_UI_Pursuit m_pursuitScr;

	public Game_UI_Pursuit m_duplicateScr;

	public Game_UI_Pursuit m_wdrawScr;

	public Game_UI_Pursuit m_shinshikiScr;

	public Game_UI_Strategy_Manager m_strategyManager;

	public BattleResultManager m_resultManager;

	public BattleSkillGaugeManager m_skillGaugeManager;

	public BattleSkillReserveManager m_skillReserveManager;

	public BattleSkillChainGaugeManager m_skillChainGaugeManager;

	public BattleTargetManager m_targetManager;

	public BattleItemManager m_itemManager;

	public BattleHaveItemManager m_haveItemManager;

	public BattleReactionManager m_reactionManager;

	public BattleTurnIconManger m_turnManager;

	public BattleEscapeManager m_escapeManager;

	public GameObject m_overHeadRoot;

	public BattleBlazeArtsGaugeManager m_blazeArtsGaugeManager;

	public BattleCutInManager m_battleCutInManager;

	public UIGrid SkillGaugeRoot;

	public GameObject m_zoneRoot;

	public UIToggle m_timeScaleToggle;

	public static Game_UI_BA_Manager GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void DispPursuitText(bool sw)
	{
	}

	public void DispDuplicatetText(bool sw)
	{
	}

	public void DispWdrawText(bool sw)
	{
	}

	public void DispShinshikiText(bool sw)
	{
	}

	public void SetSkillName(bool activeFlag, string skillName = "")
	{
	}

	public void SetSkillNameEnemy(bool activeFlag, string skillName = "")
	{
	}

	public GameObject MakeAttackMark(Vector3 targetPos)
	{
		return null;
	}

	public GameObject SkillChainCount(int chain)
	{
		return null;
	}

	public GameObject DamageCreate(Transform root, int value, int elementID, bool weak, int result = 0)
	{
		return null;
	}

	public void DamageColorChange(TweenColor tweencolor, int elementID)
	{
	}

	public void AddSkillGauge()
	{
	}
}
