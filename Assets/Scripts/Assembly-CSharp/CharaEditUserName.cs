using UnityEngine;

public class CharaEditUserName : CharaEditSelectBase
{
	[SerializeField]
	private UIInput m_sInput;

	[SerializeField]
	private UICurveLabel m_sNameLabel;

	public string Name
	{
		get
		{
			return null;
		}
	}

	public override string GetTitle()
	{
		return null;
	}

	public void Init()
	{
	}

	public void OnDecideName(string value)
	{
	}

	public void OnCancel()
	{
	}

	public bool UserNameLimit(bool force)
	{
		return false;
	}

	public void Update()
	{
	}
}
