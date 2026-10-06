using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class OtherMenuManager : MonoBehaviour
{
	public enum EMenuKind
	{
		eIMPORTANT = 0,
		ePLAYER_INFO = 1,
		eCHARA_EDIT = 2,
		eFRIEND = 3,
		eHOWTO = 4,
		eTWITTER = 5,
		eTITLE = 6,
		eCACHE_CLEAR = 7,
		eDOWNLOAD = 8,
		eCONTACT_US = 9,
		eLINK_ID = 10,
		eTERMS_OF_SERVICE = 11,
		ePRIVACY_POLICY = 12,
		eMINI_RANKING = 13,
		eEND = 14
	}

	[StructLayout((LayoutKind)0, Size = 16)]
	private struct MenuKind
	{
		public string Name;

		public string Icon;

		public MenuKind(string name, string icon)
		{
			Name = null;
			Icon = null;
		}
	}

	private readonly MenuKind[] menuKind;

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private UIGrid m_sGrid;

	[SerializeField]
	private GameObject m_goPrefab;

	[SerializeField]
	private UIScrollListArrow m_sArrow;

	[SerializeField]
	private SpawnPrefabData m_sFriendList;

	[SerializeField]
	private AllAssetDownloadManager m_sDownloadWindow;

	[SerializeField]
	private ImportantListManager m_sImportantList;

	private CharaEditManager m_sCharaEdit;

	private PlayerDetailManager m_sPlayerDetail;

	private FriendList m_sFriendInfo;

	private OtherMenuItem m_sFriendButton;

	private Action<bool> m_sOnEditEvent;

	private bool m_bCreate;

	private void Create()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OnSelectMenu(EMenuKind kind)
	{
	}

	public void Init(Action<bool> onEditEvent)
	{
	}

	public void OnClose()
	{
	}
}
