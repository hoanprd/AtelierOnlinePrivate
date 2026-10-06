using UnityEngine;

public class AlterKeywordItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UIToggle m_sToggle;

	[SerializeField]
	private UIToggledObjects m_sToggleObject;

	public string Name
	{
		get
		{
			return null;
		}
	}

	public void Init(string name, bool select)
	{
	}
}
