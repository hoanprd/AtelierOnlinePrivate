using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TreasureResult : MonoBehaviour
{
	[SerializeField]
	private GameObject m_sEndButton;

	[SerializeField]
	private GameObject m_goRetryButton;

	[SerializeField]
	private GameObject m_goButtonRoot;

	[SerializeField]
	private GameObject[] m_agoTitle;

	[SerializeField]
	private Animation m_sAnim;

	private AnimationState m_sPlayAnim;

	[SerializeField]
	private Animation m_s3DAnim;

	[SerializeField]
	private GameObject m_goRewardPrefab;

	[SerializeField]
	private UIGrid m_sRewardGrid;

	[SerializeField]
	private UILabel m_sGetEther;

	private bool m_bRareDrop;

	private List<BattleResultItemIcon> m_vRewards;

	[SerializeField]
	private TreasureResultExpList m_sExp;

	private List<int> m_iBeforeLV;

	private List<int> m_iNowLV;

	private List<int> m_iBeforeEXP;

	private List<int> m_iNowEXP;

	private List<int> m_BeforeEXPcap_H;

	private List<int> m_BeforeEXPcap_L;

	private List<int> m_NowEXPcap_H;

	private List<int> m_NowEXPcap_L;

	private List<int> m_MaxLVcap;

	[SerializeField]
	private Transform[] m_atrCharaRoot;

	[SerializeField]
	private Transform[] m_atr2CharaRoot;

	[SerializeField]
	private Transform[] m_atr4CharaRoot;

	private List<GachaModel> m_vModel;

	private HuntResult m_sInfo;

	private HuntInfo m_sHuntInfo;

	private HuntForm m_sMember;

	private eMusicID m_ePrevMusic;

	private bool m_bSkip;

	private bool m_bExit;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[DebuggerHidden]
	public IEnumerator Play(HuntInfo info, HuntResult result)
	{
		return null;
	}

	public void Init(HuntInfo info, HuntResult result)
	{
	}

	private void InitEXP()
	{
	}

	private void InitItem()
	{
	}

	private void InitChara()
	{
	}

	public void StartUpdateItem()
	{
	}

	public void StartUpdateEXP()
	{
	}

	[DebuggerHidden]
	private IEnumerator UpdateItem()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator UpdateEXP()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator LevelUp()
	{
		return null;
	}

	public void Skip()
	{
	}

	public void OnExit()
	{
	}

	public void OnRetry()
	{
	}

	private void RetryStart(eHuntReturnType returnType, int wealthKind)
	{
	}
}
