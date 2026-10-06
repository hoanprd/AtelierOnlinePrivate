using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetailManager : MonoBehaviour
{
	public class OthersProfile_Photon
	{
		public EquipData equ;

		public EquipData cd_equ;

		public int[] cd_v;

		public InventoryInfo[] equInvList;

		public InventoryInfo[] cd_equInvList;

		public void printDebug()
		{
		}

		public int[] Clone_cd_v()
		{
			return null;
		}

		public InventoryInfo[] Clone_equInvList()
		{
			return null;
		}

		public InventoryInfo[] Clone_cd_equInvList()
		{
			return null;
		}
	}

	[SerializeField]
	private AnimationController[] m_asAnim;

	[SerializeField]
	private GameObject m_goMyInfoRoot;

	[SerializeField]
	private GameObject m_goFriendInfoRoot;

	[SerializeField]
	private EditCommentWindow m_sCommentEditWindow;

	[SerializeField]
	private SetDegreeWindow m_sDegreeSelectWindow;

	[SerializeField]
	private UIToggle m_sMuteToggle;

	[SerializeField]
	private UIButton m_sFriendReqButton;

	[SerializeField]
	private UIButton m_sFriendReqCancelButton;

	[SerializeField]
	private UILabel m_sFriendReqCancelText;

	[SerializeField]
	private UILabel m_sUserName;

	[SerializeField]
	private UILabel m_sComment;

	[SerializeField]
	private UILabel m_sMyID;

	[SerializeField]
	private GameObject m_goFriendMark;

	[SerializeField]
	private UITexture m_sTitleDegreeIcon;

	[SerializeField]
	private GameObject m_goDegreeEffectRare;

	[SerializeField]
	private GameObject m_goDegreeEffectHighRare;

	[SerializeField]
	private UISprite m_sJobIcon;

	[SerializeField]
	private UICurveLabel m_sLeaderName;

	[SerializeField]
	private UILabel m_sLeaderLevel;

	[SerializeField]
	private UILabel m_sLeaderLevelMax;

	[SerializeField]
	private EquipmentParamList m_sLeaderParam;

	[SerializeField]
	private EquipmentModel m_sLeaderModel;

	[SerializeField]
	private Transform m_trDegreeRoot;

	[SerializeField]
	private UILabel m_sTotalPower;

	private DegreeIcon m_sDegreeIcon;

	[SerializeField]
	private PlayerDetailMemberList m_sMemberList;

	[SerializeField]
	private GameObject m_goSkillPrefab;

	[SerializeField]
	private Transform[] m_atrActiveSkillRoot;

	[SerializeField]
	private List<PlayerDetailEquipItem> m_vEquipList;

	[SerializeField]
	private Transform m_trItemDetailRoot;

	private UserDetailBase m_sUserDetail;

	private DegreeInfo[] m_sEnableDegree;

	private EFriendState m_eFriendState;

	private bool m_bMute;

	private Action m_sOnMyCloseEvent;

	private Action<int, int> m_sOnCloseEvent;

	public void Init(PlayerInfo myInfo, Action onCloseEvent = null)
	{
	}

	public void Init(FriendDetail info, Action<int, int> onCloseEvent)
	{
	}

	public void Init(FriendDetail info, OthersProfile_Photon pInfo, Action<int, int> onCloseEvent)
	{
	}

	private void CombineFriendDetailWithPhotonInfo(FriendDetail info, OthersProfile_Photon pInfo)
	{
	}

	public void Init(RankingPartyInfoData info, PlayerInfo myInfo, Action<int, int> onCloseEvent)
	{
	}

	private void InitRequestButton()
	{
	}

	private void InitLeaderInfo(UserDetail info)
	{
	}

	private void InitPartyInfo(PartyCharaInfo[] infos, UserDetailBase user)
	{
	}

	private void SetActiveSkill(EquipData equ, List<InventoryInfo> invList)
	{
	}

	private void SetEquipList(EquipData equ, List<InventoryInfo> invList)
	{
	}

	private void InitDegree(DegreeInfo degree)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	public void OnItemDetail(GameObject target)
	{
	}

	public void OnChangeComment()
	{
	}

	public void OnChangeTitle()
	{
	}

	public void OnChangeMute()
	{
	}

	public void OnFriendRequest()
	{
	}

	public void OnFriendRequestCancel()
	{
	}

	public static PlayerDetailManager Create(Transform root)
	{
		return null;
	}
}
