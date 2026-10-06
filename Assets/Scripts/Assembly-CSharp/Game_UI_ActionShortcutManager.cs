using UnityEngine;

public class Game_UI_ActionShortcutManager : MonoBehaviour
{
	[SerializeField]
	private Color32 m_cNormal;

	[SerializeField]
	private Color32 m_cFairy;

	private Game_Gimmick_Base m_scrGimmick;

	private EGimmickKind m_eGimmick;

	private bool m_bNormalMode;

	private int m_iUseItemDF;

	public Game_UI_ActionShortcutButton m_scrButton;

	public Game_UI_ActionShortcutIcon m_scrIcon;

	public void SetNotify(bool bActive, Game_Gimmick_Base scrGmk = null, bool bForce = false)
	{
	}

	public void SetUseItemMode(bool bNormal)
	{
	}

	public void ChangeUseItemMode()
	{
	}

	public ePickupToolLook GetUseItemLook()
	{
		return (ePickupToolLook)0;
	}

	public InventoryInfo GetUseItem()
	{
		return null;
	}

	public Game_Gimmick_Base GetNowGimmick()
	{
		return null;
	}
}
