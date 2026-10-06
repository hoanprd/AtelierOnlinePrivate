using System.Collections.Generic;
using UnityEngine;

public class TrainingLevel : MonoBehaviour
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

	private List<EXPTable> m_vEXPTable;

	private CharaStatus m_sStatus;

	private int m_iNextLv;

	public int NextLv
	{
		get
		{
			return 0;
		}
	}

	public void Init(int df, CharaStatus stat)
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
