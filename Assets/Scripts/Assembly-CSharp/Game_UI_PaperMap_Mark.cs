using UnityEngine;

public class Game_UI_PaperMap_Mark : NGUI_ClickButton
{
	private enum eMainStep
	{
		Wait = 0,
		Fade_I = 1,
		Visible = 2
	}

	private eMainStep m_mainStep;

	public GameObject m_targetChild;

	private NGUI_Wrapper_Tween m_uiTween;

	private int m_linkSpotId;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetData(Vector3 pos, int spotId)
	{
	}

	protected override void DecideButton()
	{
	}
}
