using UnityEngine;

public class EquipmentListItem : MonoBehaviour
{
	public UILongTapButton m_sSelectButton;

	public Transform m_trDetailRoot;

	private ItemDetailEquipmentMini m_sData;

	public ItemDetailEquipmentMini Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool EnableEquip
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Create()
	{
	}

	public void OnDetail()
	{
	}
}
