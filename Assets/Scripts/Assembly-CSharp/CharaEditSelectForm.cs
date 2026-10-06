using UnityEngine;

public class CharaEditSelectForm : UIListViewBase<CharaEditFormItem>
{
	[SerializeField]
	private UIScrollListArrow m_sArrow;

	public void Init(int select, string prefix, int[] formList)
	{
	}

	public int Change(CharaEditFormItem select)
	{
		return 0;
	}
}
