using UnityEngine;

public class FriendListItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sLevel;

	[SerializeField]
	private UILabel m_sComment;

	[SerializeField]
	private UILabel m_sLastLoginTime;

	[SerializeField]
	private UISprite m_sOnlineMark;

	[SerializeField]
	private UILabel m_sOnlineText;

	[SerializeField]
	private GameObject m_goFriendMark;

	[SerializeField]
	private GameObject m_goGuildMark;

	[SerializeField]
	private GameObject m_goRoomInfoRoot;

	[SerializeField]
	private UILabel m_sRoomAreaName;

	[SerializeField]
	private UILabel m_sRoomAccessTime;

	[SerializeField]
	private UIButton m_sJoinRoomButton;

	[SerializeField]
	private UIButton m_sDetailButton;

	[SerializeField]
	private GameObject m_goFriendMenu;

	[SerializeField]
	private GameObject m_goRequestMenu;

	[SerializeField]
	private GameObject m_goRequestCancelMenu;

	[SerializeField]
	private GameObject m_goAcceptMenu;

	[SerializeField]
	private GameObject m_goMuteCancelMenu;

	[SerializeField]
	private Transform m_trDegreeRoot;

	private FriendData m_sData;

	private DegreeIcon m_sDegreeIcon;

	private bool m_bJoinButtonEnable;

	public FriendData Data
	{
		get
		{
			return null;
		}
	}

	private void LateUpdate()
	{
	}

	private void UpdatebuttonColor()
	{
	}

	public void Init(FriendData data)
	{
	}

	public void SetState(EFriendState state, int ignore)
	{
	}

	private bool InitOnlineMark(string last)
	{
		return false;
	}

	private void InitDegree(DegreeInfo degree)
	{
	}

	private void InitLastLogin(UILabel target, string loginTime)
	{
	}
}
