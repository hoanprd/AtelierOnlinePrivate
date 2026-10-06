using UnityEngine;

public class QuestCharaWindow : UIListViewBase<QuestCharaListItem>
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UITexture m_txCharaPic;

	[SerializeField]
	private GameObject m_goNoneMark;

	public void Init(int charaDF)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}
}
