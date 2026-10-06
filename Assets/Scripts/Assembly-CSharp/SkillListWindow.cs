using System.Collections.Generic;
using UnityEngine;

public class SkillListWindow : MonoBehaviour
{
	public enum ETabKind
	{
		eEQUIP = 0,
		eCHARA = 1
	}

	[SerializeField]
	private UITexture m_txCharaFace;

	[SerializeField]
	private UILabel m_sCharaName;

	[SerializeField]
	private UILabel m_sCharaLevel;

	[SerializeField]
	private GameObject m_goSkillTitle;

	[SerializeField]
	private GameObject m_goStatusLVMAX;

	[SerializeField]
	private GameObject m_goStatusNow;

	[SerializeField]
	private UITable m_sTable;

	[SerializeField]
	private GameObject m_goEquipSkillPrefab;

	[SerializeField]
	private GameObject m_goCharaSKillPrefab;

	[SerializeField]
	private SkillListCharaParam m_sCharaParam;

	[SerializeField]
	private BlazeArtsParam m_sBlazeArtsParam;

	public UITweenReset m_sAnim;

	public UIScrollListArrow m_scrArrow;

	public UIScrollView m_scrView;

	public UIToggle m_tglCharaSkill;

	public UIToggle m_tglEquipSkill;

	public UIToggle m_tglCharaParam;

	public UIToggle m_tglBlazeArtsParam;

	public UIGrid m_tglGrid;

	private List<SkillListItem> m_vEquipSkillList;

	private List<SkillCharaListItem> m_vCharaSKillList;

	private int m_iEquipSKillItemNum;

	private int m_iCharaSKillItemNum;

	private bool m_bInit;

	private ETabKind m_eKind;

	private const int ciTAB_GROUP = 12;

	public int m_iDebugSkill;

	public void InitCharaStatus(PartyMember mem)
	{
	}

	public void InitCharaParam(int charaDF, int lv)
	{
	}

	public void Init(CharaDetail chara, List<InventoryInfo> inv = null)
	{
	}

	public void InitCharaSkillOnly(CharaDetail chara, List<InventoryInfo> inv = null)
	{
	}

	public void InitGachaSkillWindow(CharaDetail chara, List<InventoryInfo> inv = null)
	{
	}

	public void InitBlazeArtsOnly(CharaDetail chara)
	{
	}

	private void OnInit(CharaDetail chara, List<InventoryInfo> inv = null)
	{
	}

	public void OnChangeChara()
	{
	}

	public void OnChangeEquip()
	{
	}

	public void OnChangeCharaParam()
	{
	}

	public void OnChangeBlazeArtsParam()
	{
	}

	private void Reset()
	{
	}

	private void InitEquip(CharaDetail chara, List<InventoryInfo> inv)
	{
	}

	private void InitChara(CharaDetail chara)
	{
	}

	private void InitCharaParam(CharaDetail chara)
	{
	}

	private void InitBlazeArtsParam(CharaDetail chara)
	{
	}

	private SkillListItem GetEquipSkillObject()
	{
		return null;
	}

	private SkillCharaListItem GetCharaSkillObject()
	{
		return null;
	}

	public void OnDissmis()
	{
	}

	private void OnClose()
	{
	}
}
