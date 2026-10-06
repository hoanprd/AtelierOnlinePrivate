using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TrainingManager : MonoBehaviour
{
	public enum EGrowKind
	{
		eNONE = 0,
		eEXCEED = 1,
		eFOOD = 2,
		ePOTION = 3,
		eBlazeMateria = 4
	}

	[SerializeField]
	private SpawnPrefabData m_sLimitbreakDirPrefab;

	private LimitbreakDirectionManager m_sLimitbreakDir;

	[SerializeField]
	private SpawnPrefabData m_sQuestListPrefab;

	[SerializeField]
	private AnimationController m_sTitleAnim;

	[SerializeField]
	private AnimationController m_sMenuAnim;

	[SerializeField]
	private AnimationController m_sStatusAnim;

	[SerializeField]
	private AnimationController m_sBlazeArtsStatusAnim;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private UILabel m_sCharaNum;

	[SerializeField]
	private GameObject[] m_atrMenuItem;

	[SerializeField]
	private UITexture m_txExeedFaceIcon;

	[SerializeField]
	private TrainingExeedNumInfo m_sExeedNum;

	[SerializeField]
	private GameObject[] m_agoPage;

	[SerializeField]
	private GameObject m_sManaRoot;

	[SerializeField]
	private UILabel m_sManaLab;

	[SerializeField]
	private UILabel m_sExceedPrice;

	[SerializeField]
	private GameObject m_goExceedEffect;

	[SerializeField]
	private TrainingAnimEvent m_sExceedAnimEvent;

	[SerializeField]
	private UICurveLabel m_sCharaName;

	[SerializeField]
	private EquipmentModel m_sModel;

	[SerializeField]
	private UITexture m_txCharaImage;

	[SerializeField]
	private TrainingLimitbreakMark m_sLimitBreakMark;

	[SerializeField]
	private TrainingLevel m_sLevel;

	[SerializeField]
	private GameObject m_sModelRoot;

	[SerializeField]
	private GameObject m_sModelNameRoot;

	[SerializeField]
	private TrainingBlazeArtsLevel m_sBlazeArtsLevel;

	[SerializeField]
	private TrainingPotionWindow m_sPotionWindow;

	[SerializeField]
	private TrainingFoodWindow m_sFoodWindow;

	[SerializeField]
	private LimitbreakWindow m_sLimitbreakWindow;

	[SerializeField]
	private TrainingBlazeMateriaWindow m_sBlazeMateriaWindow;

	[SerializeField]
	private GameObject m_goPotionBadge;

	[SerializeField]
	private GameObject m_goFoodBadge;

	[SerializeField]
	private GameObject m_goExceedBadge;

	[SerializeField]
	private GameObject m_goBlazeArtsBadge;

	[SerializeField]
	private UIButton m_sPotionButton;

	[SerializeField]
	private UIButton m_sExceedButton;

	[SerializeField]
	private UIButton m_sFoodgButton;

	[SerializeField]
	private LockMark m_sFoodLockMark;

	[SerializeField]
	private UIButton m_sBlazeArtsButton;

	[SerializeField]
	private TrainingParam m_sParam;

	public SpawnPrefabData m_sSkillWindow;

	private List<PartyMember> m_vMember;

	private List<GrowCharaData> m_vCharaInfo;

	private List<InventoryInfo> m_vEquipList;

	private List<EXPTable> m_vEXPTable;

	private int m_iSelectIndex;

	private EGrowKind m_eKind;

	private int m_iExeedItemKind;

	private PartyEditRequest m_sRequest;

	private LevelUpManager m_sLevelupWindow;

	private CharaDetail m_sPrevData;

	private GameObject m_goTouchBlockCollision;

	private List<int> m_iBlazeArtsList;

	public void Init(List<PartyMember> member, List<InventoryInfo> equip, GrowCharaData startChara, PartyEditRequest req)
	{
	}

	private void OnStatusInAnimEnd()
	{
	}

	private void SetButtonActive(bool tf)
	{
	}

	public void OnClose()
	{
	}

	public void OnNextChara()
	{
	}

	public void OnPrevChara()
	{
	}

	public void OnSkillList()
	{
	}

	public void OnBlazeArtsList()
	{
	}

	public void OnCharaQuest()
	{
	}

	public void OnFoodMenu()
	{
	}

	public void OnPotionMenu()
	{
	}

	public void OnBlazeArtsMenu()
	{
	}

	public void OnExceed()
	{
	}

	public void OnExecutePotion()
	{
	}

	private void ExecutePotion()
	{
	}

	public void OnExecuteBlazeMateria()
	{
	}

	private void ExecuteBlazeMateria()
	{
	}

	public void OnExecuteFood()
	{
	}

	private void ExecuteFood()
	{
	}

	private void ModifyParam()
	{
	}

	[DebuggerHidden]
	private IEnumerator WaitLevelup(GameObject target)
	{
		return null;
	}

	private void OnCloseMenu()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OutMainMenu()
	{
	}

	public void OnExceedExec()
	{
	}

	private void DispExceedDir()
	{
	}

	private void LoadChara(int index)
	{
	}

	private void InitChara()
	{
	}

	private void UpdateBadge()
	{
	}

	private void UpdateExceedInfo(GrowCharaData ch)
	{
	}

	private void UpdatePotionInfo()
	{
	}

	private void UpdateBlazeMateriaInfo(bool isEnabled)
	{
	}

	private void UpdateFoodInfo()
	{
	}

	public void OnPlayAction()
	{
	}

	private void SetCover(bool sw)
	{
	}

	private void OnDisable()
	{
	}

	public void OnClosePotioniWindow()
	{
	}
}
