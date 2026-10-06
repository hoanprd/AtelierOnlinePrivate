using UnityEngine;

public class DungeonFloorMoveDialogBar : NGUI_ClickButton
{
	public enum eLabel
	{
		Lv = 0,
		Name = 1,
		Floor = 2,
		EnumMax = 3
	}

	private DungeonFloorMoveDialog.FloorInfo m_clsInfo;

	[SerializeField]
	private DungeonFloorMoveDialog.eButton m_eButton;

	[SerializeField]
	private UILabel[] m_scrLabelAry;

	[SerializeField]
	private UISprite m_scrPlayerMark;

	private void SetLabelText(eLabel eKind, string strText)
	{
	}

	public void Init(DungeonFloorMoveDialog.FloorInfo clsInfo)
	{
	}

	protected override void DecideButton()
	{
	}
}
