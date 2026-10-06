using UnityEngine;

public class ShopLineupWindow : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private ShopLineupSkill m_sSkillList;

	[SerializeField]
	private ShopLineupMaterial m_sMaterialList;

	[SerializeField]
	private UITable m_sTable;

	[SerializeField]
	private UIScrollListArrow m_sArrow;

	public void Init(GachaInfo.Data info, ShopGachaShow.Item detail)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
