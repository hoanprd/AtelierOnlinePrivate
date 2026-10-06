using System.Collections.Generic;
using UnityEngine;

public class BattleTargetManager : UIBase
{
	public Color[] casCOLOR;

	private List<int> m_IconOrderList;

	private MultiPlay_BattleData m_battleData;

	private Transform m_button;

	private Dictionary<int, Transform> trans;

	private Dictionary<int, BattleTargetItem> cmp;

	public void Init()
	{
	}

	public void Add(MultiPlay_BattleMemberData member)
	{
	}

	public void Update()
	{
	}

	public void SetDraw(bool enableFlag)
	{
	}

	public void Delete()
	{
	}
}
