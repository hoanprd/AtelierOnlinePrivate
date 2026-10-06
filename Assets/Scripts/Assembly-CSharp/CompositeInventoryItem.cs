using UnityEngine;

public class CompositeInventoryItem : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goLimitBreakMark;

	protected InventoryInfo m_sMaterial;

	protected ItemBar m_sItemBar;

	public ItemBar Item
	{
		get
		{
			return null;
		}
	}

	public InventoryInfo Material
	{
		get
		{
			return null;
		}
	}

	public bool LimitBreak
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Init(InventoryInfo inventory, ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}

	public void Init(CompositeMaterial mat, ItemBarEvent selectEvent, ItemBarEvent detailEvent)
	{
	}
}
