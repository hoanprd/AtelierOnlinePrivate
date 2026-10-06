using UnityEngine;

public class Game_UI_Strategy_Manager : MonoBehaviour
{
	private enum eMainStep
	{
		Wait = 0,
		Slide_I = 1,
		Visible = 2,
		Slide_O = 3
	}

	private static readonly string[] m_strategyNameArray;

	private NGUI_Wrapper_Tween m_uiTween;

	public GameObject m_tweenAnim_Parent;

	public GameObject m_listitem_Child;

	public Game_UI_Strategy_Button m_mainButton;

	private bool m_menuOpenReqFlag;

	private eMainStep m_mainStep;

	public void Reset()
	{
	}

	public static string GetStrategyName(int kind)
	{
		return null;
	}

	public void BattleEnd()
	{
	}

	public void SetDraw(bool enableFlag)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OpenList()
	{
	}

	public void SetStrategyKind(eStrategyKind kind, bool isReset = false)
	{
	}

	public eStrategyKind GetStrategyKind()
	{
		return eStrategyKind.eFullPower;
	}
}
