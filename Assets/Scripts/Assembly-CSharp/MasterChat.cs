using System.Collections.Generic;
using UnityEngine;

public class MasterChat : ScriptableObject
{
	public List<ChatInfo> List;

	private Dictionary<eChatTab, List<ChatInfo>> Dic;

	public ChatInfo Find(int iId)
	{
		return null;
	}

	public List<ChatInfo> FindList(eChatTab ePhrase)
	{
		return null;
	}
}
