using System;
using System.Collections.Generic;
using UnityEngine;

public class ExqRoomBar : MonoBehaviour
{
	[Serializable]
	public class Member
	{
		public UIGrid sGrid;

		public UITexture[] atxIcon;

		public void Init(List<string> chara_ids)
		{
		}
	}

	[Serializable]
	public class SideAndChara
	{
		public GameObject goRoot;

		public UILabel sNo;

		public UILabel sType;
	}

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UISprite m_sKindIcon;

	[SerializeField]
	private GameObject[] m_goProgressMark;

	[SerializeField]
	private UITweenReset m_sSelectAnim;

	[SerializeField]
	private GameObject m_goSelectMark;

	[SerializeField]
	private UITweenReset m_sBringinAnim;

	[SerializeField]
	private Member m_sMemberList;

	[SerializeField]
	private UILabel m_sOsnerUserName;

	[SerializeField]
	private UILabel m_sOsnerCharaLv;

	private QuestDetail m_sRootInfo;

	private List<QuestDetail> m_vInfo;

	private MasterQuestInfo m_sMaster;

	private RoomInfo m_sRoomInfo;

	private int m_iRootID;

	public QuestDetail Info
	{
		get
		{
			return null;
		}
	}

	public MasterQuestInfo Master
	{
		get
		{
			return null;
		}
	}

	public RoomInfo RoomInfo
	{
		get
		{
			return null;
		}
	}

	public int RootID
	{
		get
		{
			return 0;
		}
	}

	public bool IsInclude(int df)
	{
		return false;
	}

	public void UpdateInfo(QuestDetail detail)
	{
	}

	public void SetProgressMark()
	{
	}

	public void Init(RoomInfo room, List<MasterQuestInfo> master, List<QuestDetail> detail, bool bringin, bool select, int root)
	{
	}

	public void Init(RoomInfo room, MasterQuestInfo master, QuestDetail detail, bool bringin, bool select, int root = 0)
	{
	}

	public void Select(bool sw)
	{
	}

	private void InitUnlockInfo()
	{
	}
}
