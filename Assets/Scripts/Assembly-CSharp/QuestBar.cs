using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestBar : MonoBehaviour
{
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
	private GameObject m_goBadge;

	[SerializeField]
	private SideAndChara m_sSideAndCharaInfo;

	[SerializeField]
	private GameObject m_goFreeRoot;

	[SerializeField]
	private UISprite m_sKindIcon;

	[SerializeField]
	private QuestTargetIcon m_sTargetIcon;

	[SerializeField]
	private GameObject m_goExtraMark;

	[SerializeField]
	private GameObject m_goExtraMark2;

	[SerializeField]
	private GameObject m_goSpecialMark;

	[SerializeField]
	private GameObject m_goMainMark;

	[SerializeField]
	private GameObject m_goAcademyMark;

	[SerializeField]
	private GameObject m_goNewMark;

	[SerializeField]
	private GameObject m_goClearMark;

	[SerializeField]
	private UILabel m_sClearText;

	[SerializeField]
	private GameObject m_goCharangeMark;

	[SerializeField]
	private GameObject m_goLockMark;

	[SerializeField]
	private UILabel m_sUnlockInfo;

	[SerializeField]
	private UILabel m_sUnlockInfo2;

	[SerializeField]
	private GameObject m_goProgressMark;

	[SerializeField]
	private GameObject m_goBlackFilter;

	[SerializeField]
	private UITweenReset m_sSelectAnim;

	[SerializeField]
	private GameObject m_goSelectMark;

	[SerializeField]
	private UITweenReset m_sBringinAnim;

	[SerializeField]
	private GameObject m_goPartsRoot;

	[SerializeField]
	private UILabel m_sNotes;

	[SerializeField]
	private UILabel m_sLimit;

	[SerializeField]
	private UITexture m_txGetChara;

	[SerializeField]
	private UILabel m_sKeyQuest;

	private QuestDetail m_sRootInfo;

	private List<QuestDetail> m_vInfo;

	private MasterQuestInfo m_sMaster;

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

	public void UpdateBadge()
	{
	}

	public void InitOrder(MasterQuestInfo master, QuestDetail detail, bool select)
	{
	}

	public void Init(List<MasterQuestInfo> master, List<QuestDetail> detail, bool bringin, bool select, int root)
	{
	}

	public void Init(MasterQuestInfo master, QuestDetail detail, bool bringin, bool select, int root = 0)
	{
	}

	public void Select(bool sw)
	{
	}

	private void InitUnlockInfo()
	{
	}

	private void InitKindMark()
	{
	}

	private void InitKeyQuest(int chapter)
	{
	}

	private void InitPartyin(int partyIn)
	{
	}
}
