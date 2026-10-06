using UnityEngine;

public class ImportantListManager : UIListViewBase<ImportantListItem>
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UIScrollListArrow m_sArrow;

	public virtual void Bringin()
	{
	}

	public virtual void OnClose()
	{
	}

	protected virtual void OnCloseEnd()
	{
	}

	public void Init()
	{
	}
}
