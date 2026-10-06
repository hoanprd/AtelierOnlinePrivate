using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ExqResult : MonoBehaviour
{
	private static ExqResult m_inst;

	private Dictionary<int, string> dicClearStatusTitle;

	[SerializeField]
	private UILabel m_lQuestTitle;

	[SerializeField]
	private UILabel m_lClearTitle;

	[SerializeField]
	private GameObject m_sEndButton;

	[SerializeField]
	private GameObject m_goRetryButton;

	[SerializeField]
	private GameObject m_goButtonRoot;

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

	private ExqResultObserver m_observer;

	private ExtraQuestData m_extraQuestData;

	private MasterQuestInfo m_questInfo;

	private bool m_bRareDrop;

	private List<BattleResultItemIcon> m_vRewards;

	[SerializeField]
	private Transform[] m_atr2CharaRoot;

	[SerializeField]
	private Transform[] m_atr4CharaRoot;

	private List<GachaModel> m_vModel;

	[SerializeField]
	private UILabel[] m_alUserName_f4;

	[SerializeField]
	private UILabel[] m_alUserName_f2;

	private eMusicID m_ePrevMusic;

	private bool m_bSkip;

	private bool m_bExit;

	private Dictionary<long, FriendProfileResponse> dicClsFPRes;

	private Transform[] root;

	private UILabel[] lUserNames;

	[SerializeField]
	private UISprite m_spBGSheet;

	[SerializeField]
	private UILabel m_lInfoProgressMessage;

	[SerializeField]
	private GameObject m_goInformation;

	private bool isPrepareCharaModel;

	[SerializeField]
	private bool m_isAlreadyPlayADV;

	public Dictionary<int, ExqClearTarget_MP_CharaData> clearParty
	{
		get
		{
			return null;
		}
	}

	public static ExqResult GetInst()
	{
		return null;
	}

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
	public IEnumerator Play(ExqResultObserver observer)
	{
		return null;
	}

	public void Init()
	{
	}

	private void InitItem()
	{
	}

	private void InitChara()
	{
	}

	[DebuggerHidden]
	private IEnumerator PrePareMultiData()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator SetPartyInfoListData()
	{
		return null;
	}

	public void OnLoadADV()
	{
	}

	[DebuggerHidden]
	private IEnumerator WaitADV()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator SendReturnRoomName(Action callback)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator SearchReturnRoom(Action callbackFindRoom, Action callbackNotFoundRoom)
	{
		return null;
	}

	public void StartUpdateItem()
	{
	}

	[DebuggerHidden]
	private IEnumerator UpdateItem()
	{
		return null;
	}

	public void ExitRoomOwner()
	{
	}

	public void ExitRoomMember()
	{
	}

	public void OnExit()
	{
	}
}
