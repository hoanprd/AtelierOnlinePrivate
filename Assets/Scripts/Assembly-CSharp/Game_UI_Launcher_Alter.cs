using UnityEngine;

public class Game_UI_Launcher_Alter : Game_UI_Launcher_SubMenu
{
	[SerializeField]
	private UIButton m_sNormalButton;

	[SerializeField]
	private UIButton m_sRespireButton;

	public void Init(EventDelegate normal, EventDelegate respire)
	{
	}

	public override void UpdateState()
	{
	}
}
