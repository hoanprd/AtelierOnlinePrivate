using System.Collections.Generic;
using UnityEngine;

public class Game_UI_Chat_Manager : MonoBehaviour
{
	public enum eMode
	{
		Field = 0,
		Battle = 1,
		Town = 2,
		UI = 3,
		ExqRoom = 4
	}

	public enum eButton
	{
		Phrase = 0,
		Stamp = 1,
		EnumMax = 2
	}

	public enum eActiveOrder
	{
		Battle = 0,
		ADV = 1,
		UI = 2,
		All = 3
	}

	private static readonly string c_strChatStampPath;

	private static readonly string[] c_strSystemChatArray;

	private static Game_UI_Chat_Manager s_Instance;

	private eMode m_eMode;

	private bool m_bOnline;

	private GameObject m_goWindowRoot;

	private Game_UI_Chat_Window_Manager m_scrWindow;

	private bool m_bFadeNow;

	private bool[] m_bActiveFlagAry;

	[SerializeField]
	private GameObject m_goScreenRoot;

	[SerializeField]
	private Game_UI_Chat_Screen_Manager m_scrScreen;

	[SerializeField]
	private GameObject m_goWindowPrefab;

	public static Game_UI_Chat_Manager GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	private bool IsAllActive()
	{
		return false;
	}

	public static void SetStampSprite(UISprite scrSprite, string strSpriteName)
	{
	}

	public static string GetPhrase(int iId)
	{
		return null;
	}

	public static List<ChatInfo> GetChatList(eChatTab eTab)
	{
		return null;
	}

	public static string GetStampSpriteName(int iId)
	{
		return null;
	}

	public static string GetSystemMessage(int iId)
	{
		return null;
	}

	public void SetFade(bool bStart)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void SetMode(eMode eReq)
	{
	}

	public static void SetOnline(bool bOnline)
	{
	}

	public static void SetActive(bool bActive, eActiveOrder eActive = eActiveOrder.All)
	{
	}

	public static void SetActive_Screen(bool bActive)
	{
	}

	public void AddLog(MultiPlay_ChatData clsChat)
	{
	}

	public int GetPhraseListCount()
	{
		return 0;
	}

	public eMode GetNowMode()
	{
		return eMode.Field;
	}

	public eChatTab GetNowTab()
	{
		return eChatTab.Useful;
	}

	public void SendChat(int iType, string strText)
	{
	}

	public void ClickedButton(eButton eClicked, int iId = 0)
	{
	}

	public void ClickSendButton(string text)
	{
	}
}
