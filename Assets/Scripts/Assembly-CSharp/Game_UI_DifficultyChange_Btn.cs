using UnityEngine;

public class Game_UI_DifficultyChange_Btn : NGUI_ClickButton
{
	[SerializeField]
	private UIButton scrButton;

	[SerializeField]
	private GameObject Normal_Btn;

	[SerializeField]
	private GameObject Hard_Btn;

	[SerializeField]
	private GameObject ExtraQuest_Btn;

	protected override void DecideButton()
	{
	}

	public void ChangeButtonUI(bool isHardMode)
	{
	}

	public void SetActivate(bool active)
	{
	}
}
