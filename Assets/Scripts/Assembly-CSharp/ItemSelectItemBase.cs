using UnityEngine;

public abstract class ItemSelectItemBase : MonoBehaviour
{
	[SerializeField]
	protected Transform m_trItemBarRoot;

	[SerializeField]
	protected UISprite m_sSelectMark;

	[SerializeField]
	protected UISprite m_sBackground;

	[SerializeField]
	protected GameObject m_goNewIcon;

	[SerializeField]
	protected UIButton m_sDetailButton;

	protected bool m_bSelect;

	protected ItemBar m_sItemBar;

	public ItemBar Item
	{
		get
		{
			return null;
		}
	}

	public bool Select
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool New
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
