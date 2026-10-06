using UnityEngine;

public class Game_UI_Launcher_Party : Game_UI_Launcher_SubMenu
{
	[SerializeField]
	private UIButton m_sPartyEdit;

	[SerializeField]
	private UIButton m_sTraning;

	[SerializeField]
	private UIButton m_sEquip;

	public void Init(EventDelegate edit, EventDelegate traning, EventDelegate equip)
	{
	}

	public override void UpdateState()
	{
	}
}
