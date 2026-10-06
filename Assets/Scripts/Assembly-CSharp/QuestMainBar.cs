using System.Collections.Generic;
using UnityEngine;

public class QuestMainBar : MonoBehaviour
{
	public UIButton m_sSelectButton;

	public UIButton m_sRewardButton;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sNo;

	[SerializeField]
	private UILabel m_sProgress;

	[SerializeField]
	private GameObject m_goSideProgressRoot;

	[SerializeField]
	private UITexture m_txAreaImage;

	[SerializeField]
	private UISprite m_sRewardIcon;

	[SerializeField]
	private UITexture m_txFaceIcon;

	[SerializeField]
	private GameObject m_goLockMark;

	[SerializeField]
	private GameObject m_goCompleteMark;

	[SerializeField]
	private GameObject m_goSelectMark;

	[SerializeField]
	private GameObject m_goClearMark;

	[SerializeField]
	private UIGrid m_sMainProgressGrid;

	[SerializeField]
	private QuestStatus m_sStatus;

	[SerializeField]
	private UIGrid m_sConditionGrid;

	[SerializeField]
	private GameObject m_goConditionPrefab;

	[SerializeField]
	private GameObject m_goBlackFilter;

	[SerializeField]
	private GameObject m_goDetailRoot;

	private List<MasterQuestInfo> m_vsMaster;

	private List<QuestDetail> m_vsPlayInfo;

	private int m_iChapter;

	private QuestDetail m_sCurrent;

	private MasterQuestInfo m_sMaster;

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

	public int Chapter
	{
		get
		{
			return 0;
		}
	}

	public void Select(bool sw, bool immidiate = false)
	{
	}

	public void InitOrder(int chapter, List<QuestDetail> playInfo, int activeChapter = 1, bool select = false)
	{
	}

	public void Init(int chapter, List<QuestDetail> playInfo, DegreeMissionInfo[] degree, int activeChapter = 1, bool select = false)
	{
	}

	private void InitProgress()
	{
	}

	private void InitCondition(MasterQuestInfo root, DegreeMissionInfo[] degree)
	{
	}
}
