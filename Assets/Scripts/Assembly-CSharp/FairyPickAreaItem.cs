using UnityEngine;

public class FairyPickAreaItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UIToggledObjects m_sToggleObj;

	[SerializeField]
	private UIToggle m_sToggle;

	private FairyItemInfo m_sData;

	public string AreaName
	{
		get
		{
			return null;
		}
	}

	public bool IsSelect
	{
		get
		{
			return false;
		}
	}

	public FairyItemInfo Data
	{
		get
		{
			return null;
		}
	}

	public void Init(FairyItemInfo info, bool select = false)
	{
	}
}
