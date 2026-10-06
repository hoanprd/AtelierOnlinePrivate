using UnityEngine;

public class CharaEditGender : CharaEditSelectBase
{
	[SerializeField]
	private CharaEditSelectItem m_sMan;

	[SerializeField]
	private CharaEditSelectItem m_sWoman;

	private MakeCharaData m_sFemaleDefault;

	private MakeCharaData m_sMaleDefault;

	public override string GetTitle()
	{
		return null;
	}

	public void Init()
	{
	}

	public void OnChange(CharaEditSelectItem select)
	{
	}
}
