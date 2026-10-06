using UnityEngine;

public class Academy_Loading : Menu_Base
{
	public enum eDirection
	{
		GotoField = 0,
		GotoAcademy = 1
	}

	private enum eMainStep
	{
		First_Init = 0,
		First_Wait = 1,
		FadeI_Init = 2,
		FadeI_Wait = 3,
		Main_Init = 4,
		Main_Wait = 5,
		FadeO_Init = 6,
		FadeO_Wait = 7,
		End = 8
	}

	private eMainStep m_mainStep;

	private static bool m_loadIsFinished;

	public UILabel m_uiLabel_English;

	public UILabel m_uiLabel_Japanese;

	public Animation m_targetAnime;

	private float m_waitSec_Now;

	private float m_waitSec_Max;

	private static readonly float m_waitSec_GotoAcademy;

	private static readonly float m_waitSec_GotoField;

	protected override void MenuUpdate()
	{
	}

	public void SetData(eDirection dir)
	{
	}

	public static void SetLoadStart(eDirection dir)
	{
	}

	public static bool IsFinished()
	{
		return false;
	}
}
