using UnityEngine;

public class MissionBar : MonoBehaviour
{
	public enum eLabel
	{
		Title = 0,
		RestTime = 1,
		Detail = 2,
		Progress = 3,
		EnumMax = 4
	}

	private DegreeIcon m_scrDegreeIcon;

	[SerializeField]
	private UILabel[] m_scrLabelAry;

	[SerializeField]
	private UISlider m_scrProgressBar;

	[SerializeField]
	private GameObject[] m_goDailyActiveAry;

	[SerializeField]
	private GameObject[] m_goDegreeActiveAry;

	[SerializeField]
	private Transform m_trDegreeMarkRoot;

	[SerializeField]
	private MissionDifficultyMarkList m_scrDifficultyMark;

	[SerializeField]
	private ItemBarList m_scrItemBarList;

	[SerializeField]
	private GameObject m_goAchieveIcon;

	[SerializeField]
	private Transform m_trDetailRoot;

	private void SetLabelText(eLabel eKind, string strText)
	{
	}

	public void OnRewardDetail(ItemBar target)
	{
	}

	public void Init(DailyMissionInfo.Info clsInfo)
	{
	}

	public void Init(DegreeMissionInfo clsInfo)
	{
	}
}
