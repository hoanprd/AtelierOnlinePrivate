using UnityEngine;

[ExecuteInEditMode]
public class TabItem<T> : MonoBehaviour
{
	[SerializeField]
	protected T m_eKind;

	[SerializeField]
	protected GameObject m_goDisable;

	[SerializeField]
	protected UIToggle m_sToggle;

	[SerializeField]
	protected UIToggledObjects m_sToggleObj;

	[SerializeField]
	protected UIButton m_sButton;

	public T Kind
	{
		get
		{
			return default(T);
		}
	}

	public UIToggle Toggle
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Init(bool enable, bool select)
	{
	}
}
