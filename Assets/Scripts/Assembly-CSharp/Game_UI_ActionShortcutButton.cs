using UnityEngine;

public class Game_UI_ActionShortcutButton : Game_UI_ActionButtonBase
{
	public UISprite m_sIcon;

	public UILabel m_sName;

	public UITweenReset m_sBringinAnim;

	public UITweenReset m_sDismissAnim;

	public UILabel m_sBombRarity;

	public GameObject m_goShadow;

	public GameObject m_goChangeRoot;

	public UIButton m_sChangeBtn;

	public UILabel m_sUseItemLabel;

	public UIButton m_sAlterBtn;

	public GameObject m_goAlterLack;

	public GameObject m_goVine;

	public UITweenReset m_sVineTween;

	private void Awake()
	{
	}

	public void SetNotify(bool active, bool enable, Game_Gimmick_Base gmk = null)
	{
	}

	private void SetIcon(Game_Gimmick_Base gmk)
	{
	}

	private void OnChangeItem()
	{
	}

	private void OnAlter()
	{
	}

	private void OnReturnAlter()
	{
	}

	public void SetUseItemMode(Color color, int invNum, bool numActive, bool activeItemBtn, bool activeAlterBtn, bool activeLack, bool activeVine, string itemName)
	{
	}

	public void OnAction()
	{
	}

	public void OnClose()
	{
	}
}
