using UnityEngine;

public class Game_UI_Strategy_Button : NGUI_ClickButton
{
	public UILabel m_textLabel_StrategyName;

	public GameObject m_Arrow;

	public bool m_UpArrow;

	private eStrategyKind m_strategyKind_Now;

	public void SetData(eStrategyKind kind)
	{
	}

	public void SetText(eStrategyKind kind)
	{
	}

	protected override void DecideButton()
	{
	}

	public void ChangeArrow(bool reset = false)
	{
	}
}
