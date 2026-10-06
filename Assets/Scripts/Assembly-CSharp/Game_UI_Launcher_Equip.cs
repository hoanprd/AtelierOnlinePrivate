using UnityEngine;

public class Game_UI_Launcher_Equip : Game_UI_Launcher_SubMenu
{
	[SerializeField]
	private UIButton m_sList;

	[SerializeField]
	private UIButton m_sForge;

	[SerializeField]
	private UIButton m_sEquip;

	[SerializeField]
	private UIButton m_sDispose;

	[SerializeField]
	private UIButton m_sRestore;

	[SerializeField]
	private UIButton m_sDrop;

	public void InitField(EventDelegate list, EventDelegate forge, EventDelegate equip, EventDelegate restore, EventDelegate drop)
	{
	}

	public void InitAcademy(EventDelegate list, EventDelegate forge, EventDelegate equip, EventDelegate dispose, EventDelegate restore, EventDelegate drop)
	{
	}

	public override void UpdateState()
	{
	}
}
