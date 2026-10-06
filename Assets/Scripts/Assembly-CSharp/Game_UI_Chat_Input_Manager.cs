using UnityEngine;

public class Game_UI_Chat_Input_Manager : MonoBehaviour
{
	[SerializeField]
	private UIInput m_sMessage;

	private const string cs_DefaultMessage = "ここをタッ\ufffd";

	private void Awake()
	{
	}

	public void OnSend()
	{
	}
}
