using System;

[Serializable]
public class FieldName
{
	public int iAreaNameId;

	public string strAreaName;

	public string strAreaNameSub;

	public bool IsAreaNameId(int iAreaNameId)
	{
		return false;
	}

	public AreaInfo GetAreaInfo()
	{
		return null;
	}

	public AreaNameText.eUIKind GetUIKind()
	{
		return AreaNameText.eUIKind.Large;
	}

	public bool IsVisit()
	{
		return false;
	}

	public void SetVisit()
	{
	}
}
