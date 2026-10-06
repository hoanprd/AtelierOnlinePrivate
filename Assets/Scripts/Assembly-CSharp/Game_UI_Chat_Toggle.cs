using System;
using UnityEngine;

public class Game_UI_Chat_Toggle : MonoBehaviour
{
	[SerializeField]
	private eChatTab eTab;

	[SerializeField]
	private UIToggle scrToggle;

	private Action<eChatTab, bool> acOnChanged;

	public eChatTab GetTabKind()
	{
		return eChatTab.Useful;
	}

	public UIToggle GetToggle()
	{
		return null;
	}

	public void SetCallBack(Action<eChatTab, bool> acOnChanged)
	{
	}

	private void Start()
	{
	}

	private void OnChanged()
	{
	}
}
