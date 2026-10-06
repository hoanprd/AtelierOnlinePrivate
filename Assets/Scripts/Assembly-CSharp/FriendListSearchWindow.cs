using UnityEngine;

public class FriendListSearchWindow : MonoBehaviour
{
	[SerializeField]
	private UITweenReset m_sAnim;

	[SerializeField]
	private UILabel m_sMyID;

	[SerializeField]
	private UIInput m_sTargetID;

	[SerializeField]
	private UIButton m_sDecideButton;

	private FriendListItem m_sResult;

	public void UpdateResultInfo(FriendData data)
	{
	}

	public void Init()
	{
	}

	public void OnClose()
	{
	}

	public void OnDecide()
	{
	}

	public void OnInputValue()
	{
	}

	public void OnCopyText()
	{
	}

	private void OnCloseEnd()
	{
	}
}
