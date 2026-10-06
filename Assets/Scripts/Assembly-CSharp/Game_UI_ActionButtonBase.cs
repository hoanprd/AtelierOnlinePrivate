using UnityEngine;

public class Game_UI_ActionButtonBase : MonoBehaviour
{
	public GameObject m_goDisableIcon;

	public UISprite m_sColorSprite;

	public UILabel m_sInventoryNum;

	public UIButton m_sButton;

	protected EGimmickKind m_eKind;

	protected bool m_bActive;

	protected bool m_bEnable;

	protected bool m_bDecide;

	protected bool m_bUseOK;

	protected bool m_bChangedIcon;

	public bool IsDecide
	{
		get
		{
			return false;
		}
	}

	protected bool CheckEnable(int invNum)
	{
		return false;
	}

	protected void InitEnableIcon(int num)
	{
	}

	protected string GetSpriteName(Game_Gimmick_Base gmk)
	{
		return null;
	}

	protected string GetActionName(Game_Gimmick_Base gmk)
	{
		return null;
	}

	protected void SetInventoryNum(int num, bool active)
	{
	}

	public string GetBombRarity(Game_Gimmick_Base gmk)
	{
		return null;
	}
}
