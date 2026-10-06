using System.Collections.Generic;
using UnityEngine;

public class TrainingPotionListItem : MonoBehaviour
{
	[SerializeField]
	private UIGrid m_sGrid;

	private List<ItemBar> m_vItemBar;

	public const int ciITEM_NUM = 3;

	private void Awake()
	{
	}

	public void Init(List<InventoryInfo> inv, bool enable, List<long> select, ItemBarEvent onSelect, ItemBarEvent onDetail)
	{
	}

	public void Select(List<long> select)
	{
	}
}
