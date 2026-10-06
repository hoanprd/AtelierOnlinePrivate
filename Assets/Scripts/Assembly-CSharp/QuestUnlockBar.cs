using UnityEngine;

public class QuestUnlockBar : QuestUnlockCondition
{
	[SerializeField]
	private UILabel m_sInfo;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sDetail;

	[SerializeField]
	private GameObject m_goDetailButton;

	private DegreeMissionInfo m_sProgress;

	public DegreeMissionInfo Info
	{
		get
		{
			return null;
		}
	}

	public void Init(MasterQuestInfo.UnlockTitle title, DegreeMissionInfo[] progress)
	{
	}

	public void Init(string name, string desc)
	{
	}
}
