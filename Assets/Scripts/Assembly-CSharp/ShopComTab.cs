using UnityEngine;

public class ShopComTab : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private int m_iKind;

	[SerializeField]
	private UIToggle m_sToggle;

	[SerializeField]
	private UIToggledObjects m_sToggleObj;

	[SerializeField]
	private UIButton m_sButton;

	[SerializeField]
	private GameObject m_goDisable;

	[SerializeField]
	private GameObject m_goEventMark;

	public int Kind
	{
		get
		{
			return 0;
		}
	}

	public void Init(bool enable, bool select)
	{
	}

	public void Init(int id, bool enable, bool select, bool ev)
	{
	}
}
