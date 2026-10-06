using UnityEngine;

public class Game_UI_ActionShortcutIcon : Game_UI_ActionButtonBase
{
	public Vector3 m_vDrawOffset;

	public UISprite m_sIcon;

	public UITweenReset m_sBringinAnim;

	public UITweenReset m_sDismissAnim;

	public UILabel m_sBombRarity;

	public GameObject m_goQuestionMark;

	public UITweenReset m_sIconAnim;

	private void Awake()
	{
	}

	public void SetNotify(bool active, bool enable, bool pad, Game_Gimmick_Base gmk = null)
	{
	}

	private void Update()
	{
	}

	private void SetIcon(Game_Gimmick_Base gmk)
	{
	}

	public void OnAction()
	{
	}

	public void OnClose()
	{
	}

	public void SetUseItemMode(Color color, int invNum, bool numActive)
	{
	}
}
