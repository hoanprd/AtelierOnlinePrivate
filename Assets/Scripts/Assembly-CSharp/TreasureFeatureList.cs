using System.Collections.Generic;
using UnityEngine;

public class TreasureFeatureList : UIWrapListBase
{
	[SerializeField]
	private Transform m_trDetailRoot;

	private List<PresentItemInfo> m_vItem;

	private const int ciITEM_MAX = 6;

	public void Init(List<PresentItemInfo> items)
	{
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	public void OnClose()
	{
	}

	public void OnDetail(ItemBar target)
	{
	}
}
