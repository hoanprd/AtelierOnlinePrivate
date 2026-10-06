using System.Collections.Generic;
using UnityEngine;

public class EquipmentFavListItem : MonoBehaviour
{
	public UILabel m_sName;

	public UISprite m_sCategoryIcon;

	public UILabel m_sTotalPower;

	public Color m_cEquipColor;

	public Color m_cNoneColor;

	public UIGrid m_sMarkGrid;

	public UISprite m_sEquipMark;

	private UISprite[] m_asEquipMarkList;

	private bool m_bCreate;

	[SerializeField]
	private GameObject m_sTotalPowerRoot;

	private EquipFavoInfo m_sInfo;

	public EquipFavoInfo Info
	{
		get
		{
			return null;
		}
	}

	private void Create()
	{
	}

	public void Init(EquipFavoInfo set, List<InventoryInfo> inv, EEquipKind kind)
	{
	}
}
