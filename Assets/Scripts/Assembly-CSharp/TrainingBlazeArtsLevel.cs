using System.Collections.Generic;
using UnityEngine;

public class TrainingBlazeArtsLevel : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sNow;

	[SerializeField]
	private UILabel m_sNext;

	[SerializeField]
	private UILabel m_sNextEXP;

	[SerializeField]
	private GameObject m_goNextArrow;

	[SerializeField]
	private UILabel m_sNowLevelCap;

	[SerializeField]
	private UILabel m_sNextLevelCap;

	[SerializeField]
	private UISlider m_sNowValue;

	[SerializeField]
	private UISlider m_sNextValue;

	private List<MasterBlazeArts.BlazeArtsParam> m_vEXPTable;

	private BlazeArtsStatus m_sBlazeArtsStatus;

	private int m_iNextLv;

	private int m_iNowLv;

	private int m_iMaxLv;

	private MasterBlazeArts m_sBlazeArtsMaster;

	public int NextLv
	{
		get
		{
			return 0;
		}
	}

	public int NowLv
	{
		get
		{
			return 0;
		}
	}

	public void Init(int charaDF, BlazeArtsStatus baStat)
	{
	}

	public int GetEXP(InventoryInfo feed)
	{
		return 0;
	}

	public List<InventoryInfo> GetRecommend(List<InventoryInfo> feeds)
	{
		return null;
	}

	public void Prediction(List<InventoryInfo> feeds)
	{
	}
}
