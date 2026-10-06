using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BattleResultInfo : MonoBehaviour
{
	public Animation m_sInAnim;

	public UILabel m_sGetCoin;

	public UILabel m_sTotalCoin;

	public UITexture m_sCoinIcon;

	public GameObject m_goItemIconPrefab;

	public UIGrid m_sItemListRoot;

	[SerializeField]
	private BattleResultExpList m_sExp;

	private AnimationState m_sPlayAnim;

	private bool m_bSkip;

	private bool m_bRareDrop;

	private int m_iGetCoin;

	private int m_iTotalCoin;

	private BattleFinish m_Result;

	private List<int> m_iBeforeLV;

	private List<int> m_iNowLV;

	private List<int> m_iBeforeEXP;

	private List<int> m_iNowEXP;

	private List<int> m_BeforeEXPcap_H;

	private List<int> m_BeforeEXPcap_L;

	private List<int> m_NowEXPcap_H;

	private List<int> m_NowEXPcap_L;

	private List<int> m_MaxLVcap;

	private List<InventoryInfo> m_vsGetItemList;

	private List<int> m_aiGetChestList;

	private List<BattleResultItemIcon> m_vReserveItemIcon;

	private List<BattleResultItemIcon> m_vDispItemIcon;

	private List<Sound_Loop> m_vLoopSound;

	public int m_skillRate;

	[SerializeField]
	private GameObject m_goMiniRanking;

	public UITexture m_txRankingIcon;

	public UILabel m_sRankingScore;

	[SerializeField]
	private GameObject m_goMiniBoost;

	public UILabel m_sBoost;

	[SerializeField]
	private GameObject m_gdCharaBoost;

	public UILabel m_sCharaBoost;

	[SerializeField]
	private GameObject m_gdReversalBoost;

	public UILabel m_sReversalBoost;

	public bool IsAnimEnd
	{
		get
		{
			return false;
		}
	}

	private void Awake()
	{
	}

	[DebuggerHidden]
	private IEnumerator UpdateCoin()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator UpdateEXP()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator UpdateItem()
	{
		return null;
	}

	private void ResetItemIcon()
	{
	}

	private BattleResultItemIcon GetItemIcon(InventoryInfo dropItem, int boxKind)
	{
		return null;
	}

	private void ModifyCoinValue(int getcoin, int totalcoin)
	{
	}

	public void StartUpdateCoin()
	{
	}

	public void StartUpdateItem()
	{
	}

	public void StartUpdateEXP()
	{
	}

	public void Init(List<InventoryInfo> dropItem, BattleFinish result, List<APIBattleFinish.Request.UseSkill> useSkillList)
	{
	}

	public void Skip()
	{
	}
}
