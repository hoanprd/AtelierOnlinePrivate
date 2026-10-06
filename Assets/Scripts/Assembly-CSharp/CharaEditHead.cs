using UnityEngine;

public class CharaEditHead : CharaEditSelectBase
{
	public enum EPartKind
	{
		eSKIN = 0,
		eHAIR = 1,
		eFACE = 2
	}

	[SerializeField]
	private Color[] sacSKIN_COLOR;

	[SerializeField]
	private Color[] sacCOLOR;

	[SerializeField]
	private CharaEditColorList m_sColorList;

	[SerializeField]
	private CharaEditSelectForm m_sFormList;

	[SerializeField]
	private UIScrollView m_sScroll;

	private SalonInfo m_sData;

	private EPartKind m_ePart;

	public override string GetTitle()
	{
		return null;
	}

	public void Init(EPartKind kind, SalonInfo info)
	{
	}

	public void OnChangeColor(CharaEditColorItem col)
	{
	}

	public void OnChangeForm(CharaEditFormItem form)
	{
	}
}
