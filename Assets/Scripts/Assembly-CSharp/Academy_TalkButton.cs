using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Academy_TalkButton : MonoBehaviour
{
	private static Sound_OneShot s_sPlayVoice;

	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private GameObject m_goRandomTalk;

	[SerializeField]
	private UISprite m_sQuestMark;

	[SerializeField]
	private UITweenReset m_sTween;

	[SerializeField]
	private int m_iTalkID;

	private Game_Chara_MenuUI_Base m_sTalker;

	private List<int> m_vQuestList;

	private Sound_OneShot m_sRandomVoice;

	public List<int> QuestID
	{
		get
		{
			return null;
		}
	}

	public bool IsQuest
	{
		get
		{
			return false;
		}
	}

	public int TalkID
	{
		get
		{
			return 0;
		}
	}

	public Game_Chara_MenuUI_Base Talker
	{
		get
		{
			return null;
		}
	}

	private void OnDestroy()
	{
	}

	public void SetDisp(bool disp)
	{
	}

	public void Init(int charaID, Game_Chara_MenuUI_Base talker)
	{
	}

	public void UpdateTalkInfo()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdatePosition()
	{
	}

	public static void StopRandomMessage()
	{
	}

	public void OnRandomMessage()
	{
	}

	[DebuggerHidden]
	private IEnumerator PlayRandomVoice()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
