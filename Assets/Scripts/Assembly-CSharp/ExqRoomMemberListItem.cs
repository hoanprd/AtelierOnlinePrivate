using UnityEngine;

public class ExqRoomMemberListItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sLevel;

	[SerializeField]
	private UILabel m_sComment;

	[SerializeField]
	private UISprite m_sOnlineMark;

	[SerializeField]
	private UILabel m_sOnlineText;

	[SerializeField]
	private GameObject m_goFriendMark;

	[SerializeField]
	private GameObject m_goOwnerMark;

	[SerializeField]
	private GameObject m_goGuildMark;

	[SerializeField]
	private GameObject m_goRoomInfoRoot;

	[SerializeField]
	private UILabel m_sRoomAreaName;

	[SerializeField]
	private UILabel m_sRoomAccessTime;

	[SerializeField]
	private UIButton m_sDetailButton;

	[SerializeField]
	private GameObject m_goFriendMenu;

	[SerializeField]
	private GameObject m_goOwnerTransfer;

	[SerializeField]
	private GameObject m_goFriendOrder;

	[SerializeField]
	private GameObject m_goForceKick;

	[SerializeField]
	private Transform m_trDegreeRoot;

	private DegreeIcon m_sDegreeIcon;

	private PartyMember m_vPartyData;

	private FriendDetail m_vFriendData;

	private bool m_bJoinButtonEnable;

	public PartyMember PartyData
	{
		get
		{
			return null;
		}
	}

	public FriendDetail FriendData
	{
		get
		{
			return null;
		}
	}

	public virtual void Init(PartyMember partyData, FriendDetail friendData)
	{
	}

	private void InitDegree(DegreeInfo degree)
	{
	}

	public void SetState(EFriendState state, int ignore)
	{
	}
}
