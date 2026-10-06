using System;
using UnityEngine;

public class EditCommentWindow : MonoBehaviour
{
	[SerializeField]
	private UIInput m_sComment;

	[SerializeField]
	private UITweenReset m_sAnim;

	private Action<string> m_sOnCloseEvent;

	private string m_sDefaultComment;

	public void Init(string comment, Action<string> closeEvent)
	{
	}

	public void OnDecide()
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void ChangeButtonEnabled(bool sw)
	{
	}
}
