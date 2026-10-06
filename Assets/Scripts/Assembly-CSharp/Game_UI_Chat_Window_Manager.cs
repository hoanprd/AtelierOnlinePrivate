using UnityEngine;

public class Game_UI_Chat_Window_Manager : MonoBehaviour
{
	public enum eMainStep
	{
		Network_Init = 0,
		Network_Wait = 1,
		First_Init = 2,
		First_Wait = 3,
		Control_Init = 4,
		Control_Wait = 5,
		Last_Init = 6,
		Last_Wait = 7,
		End = 8
	}

	private eChatTab m_eTab;

	private eMainStep m_eMainStep;

	private bool m_bReset;

	private bool m_bOpen;

	[SerializeField]
	private Game_UI_Chat_Window_PhraseList m_scrWindow_Phrase;

	[SerializeField]
	private Game_UI_Chat_Window_StampList m_scrWindow_Stamp;

	[SerializeField]
	private Game_UI_Chat_Window_Log m_scrWindow_Log;

	[SerializeField]
	private Game_UI_Chat_Toggle[] m_scrToggleArray;

	[SerializeField]
	private UITweenReset m_scrWindowTween;

	[SerializeField]
	private UIScrollBar m_scrScrollBar;

	[SerializeField]
	private GameObject[] m_goActiveCtrlAry;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Network_Init()
	{
	}

	private bool Network_Wait()
	{
		return false;
	}

	private void First_Init()
	{
	}

	private bool First_Wait()
	{
		return false;
	}

	private void Control_Init()
	{
	}

	private bool Control_Wait()
	{
		return false;
	}

	private void Last_Init()
	{
	}

	private bool Last_Wait()
	{
		return false;
	}

	private void SetActive(bool bActive)
	{
	}

	private void OnChangedToggle(eChatTab eTab, bool bValue)
	{
	}

	private void ChangedWindow(eChatTab eToChange)
	{
	}

	private void OnTweenEnd()
	{
	}

	public void Reset()
	{
	}

	public void SetMode(Game_UI_Chat_Manager.eMode eReq)
	{
	}

	public void SetOnline(bool bOnline)
	{
	}

	public void AddRemark(MultiPlay_ChatData clsChat)
	{
	}

	public void CloseWindow(bool bImmediate = false)
	{
	}

	public eChatTab GetNowTab()
	{
		return eChatTab.Useful;
	}

	public void OnOpenClose()
	{
	}
}
