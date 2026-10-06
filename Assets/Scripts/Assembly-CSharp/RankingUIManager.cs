using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Ranking;
using UnityEngine;

public class RankingUIManager : MonoBehaviour
{
	public const int c_iRewardItemMax = 4;

	private static readonly int sr_iPageMax;

	private static readonly string[] sr_strRankTypeNameAry;

	public static readonly string[] sr_strRuleURLAry;

	private static RankingUIManager s_scrInstance;

	public SpawnPrefabData m_scrCharaDetailPrefab;

	[SerializeField]
	private AnimationController m_scrWindowAnim;

	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private RankingUILatest m_scrLatest;

	[SerializeField]
	private RankingUIPast m_scrPast;

	[SerializeField]
	private RankingBoard m_scrBoard;

	[SerializeField]
	private RankingRewardUI m_scrRewardUI;

	[SerializeField]
	private RankingTypeTab[] m_scrTabList;

	[SerializeField]
	private GameObject m_goRankingRoot;

	[SerializeField]
	private RankingTitle m_scrTitleUI;

	[SerializeField]
	private UIButton m_scrPastBtn;

	private List<RankingMngInfo> m_clsLatestInfoList;

	private eRankingType m_eRankingType;

	private int m_iCycle;

	private bool m_bInitialized;

	private bool m_bDismissNow;

	private PlayerDetailManager m_scrDetailWindow;

	private bool m_bDetailWindow;

	private int m_iPageNow;

	public static RankingUIManager Instance
	{
		get
		{
			return null;
		}
	}

	public void Init()
	{
	}

	[DebuggerHidden]
	private IEnumerator Init_Coroutine()
	{
		return null;
	}

	public RankingMngInfo GetRankingMngInfo(eRankingType eRanking, int iCycle)
	{
		return null;
	}

	public void OnClickedPast()
	{
	}

	public void OnClickedRule()
	{
	}

	public void OnClickedReward()
	{
	}

	public void OnClickedBack()
	{
	}

	public void OnPageNext()
	{
	}

	public void OnPagePrev()
	{
	}

	public void OnChangeTab(eRankingType eRanking)
	{
	}

	public void SetTitle(string strTitle)
	{
	}

	public void ShowPlayerDetail(long lUserId)
	{
	}

	private void Awake()
	{
	}

	private void Close()
	{
	}

	private void OnDismissEnd()
	{
	}

	private void PageChange(int iAdd)
	{
	}

	private void DispPastRanking(int iCycle, int iPage)
	{
	}

	private void OnBoardUpdatePast()
	{
	}

	private void DispLatestRanking()
	{
	}

	private void OnBoardUpdateLatest()
	{
	}

	private void InitTab()
	{
	}

	private void UpdateTabObj()
	{
	}

	private void SetEnableTab(bool bEnable)
	{
	}

	private void OnRewardUIActive()
	{
	}

	private void OnRewardUIDismissEnd()
	{
	}

	private bool IsButtonOK(bool bCheckPast, bool bCheckReward)
	{
		return false;
	}

	private int GetCycle(eRankingType eRanking, int iPage = -1)
	{
		return 0;
	}

	private int GetPageMax(eRankingType eRanking)
	{
		return 0;
	}

	private bool IsExistRanking(eRankingType eRanking, int iPage)
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator ShowAdbentBattleProfile(long lUserId)
	{
		return null;
	}
}
