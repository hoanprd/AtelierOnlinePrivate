using UnityEngine;

public class EquipmentSubListItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sNoneMark;

	[SerializeField]
	private Transform m_trDetailRoot;

	private ItemBar m_sData;

	private int m_iIndex;

	public ItemBar Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Index
	{
		get
		{
			return 0;
		}
	}

	public void Create()
	{
	}

	public void Init(int index, InventoryInfo inv)
	{
	}

	public void OnDetail()
	{
	}
}
