using UnityEngine;

public class QuestSelectBar : MonoBehaviour
{
	[SerializeField]
	private UILabel m_scrTitle;

	[SerializeField]
	private QuestCategoryMark m_scrMark;

	private int m_iDF;

	public int DF
	{
		get
		{
			return 0;
		}
	}

	public void Init(int iDF, string strTitle, EQuestCategory eCatagory, EQuestGroup eGroup, int iCharaId)
	{
	}
}
