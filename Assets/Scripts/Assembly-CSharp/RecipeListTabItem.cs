using UnityEngine;

public class RecipeListTabItem : MonoBehaviour
{
	public ECategory m_eKind;

	public UILabel m_sKindName;

	public UILabel m_sBadgeNum;

	public UIToggle m_sToggle;

	public UIToggledObjects m_sToggleObj;

	public UIButton m_sButton;

	public ECategory Kind
	{
		get
		{
			return ECategory.eNONE;
		}
	}

	public bool IsSelect
	{
		get
		{
			return false;
		}
	}

	public void Init(bool selection)
	{
	}

	public void SetBadge(int num)
	{
	}
}
