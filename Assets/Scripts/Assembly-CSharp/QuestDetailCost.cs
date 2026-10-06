using System;
using UnityEngine;

public class QuestDetailCost : MonoBehaviour
{
	[Serializable]
	public class Wealth
	{
		public GameObject goRoot;

		public UITexture txWealthIcon;
	}

	[SerializeField]
	private Wealth m_sWealth;

	[SerializeField]
	private UILabel m_sCost;

	public void Init(CostInfo cost)
	{
	}
}
