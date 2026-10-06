using System.Collections.Generic;
using UnityEngine;

public class DialogFavWarningItem : MonoBehaviour
{
	[SerializeField]
	private UIGrid m_sGrid;

	private List<ItemBar> m_vItems;

	public const int ciITEM_MAX = 6;

	public void Init(List<InventoryInfo> inv)
	{
	}
}
