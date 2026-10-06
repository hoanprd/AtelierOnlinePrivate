using UnityEngine;

public class SkillSearchInventoryItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UILabel m_sSkillName;

	[SerializeField]
	private SkillMark m_sSkillMark;

	[SerializeField]
	private GameObject m_goSelectMark;

	[SerializeField]
	private GameObject m_goBlackFilter;

	[SerializeField]
	private UILabel m_sCost;

	[SerializeField]
	private GameObject m_goDisableMark;

	[SerializeField]
	private Transform m_trItemBarRoot;

	[SerializeField]
	private UILongTapButton m_sButton;

	private ItemBar m_sItemBar;

	private InventoryInfo m_sInventory;

	private bool m_bDisable;

	public InventoryInfo Inventory
	{
		get
		{
			return null;
		}
	}

	public bool Select
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Init(InventoryInfo inv)
	{
	}
}
