using UnityEngine;

public class Game_UI_Launcher_Inventory : Game_UI_Launcher_SubMenu
{
	[SerializeField]
	private UIButton m_sItemButton;

	[SerializeField]
	private UIButton m_sEquipButton;

	[SerializeField]
	private UIButton m_sDisposeButton;

	[SerializeField]
	private UIButton m_sDropButton;

	public void InitAcademy(EventDelegate item, EventDelegate equip, EventDelegate dispose)
	{
	}

	public void InitField(EventDelegate item, EventDelegate equip, EventDelegate drop)
	{
	}
}
