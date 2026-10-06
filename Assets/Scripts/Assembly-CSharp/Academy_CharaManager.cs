using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Academy_CharaManager : MonoBehaviour
{
	public class LocInfo
	{
		public bool bQuest;

		public int iCharaDF;

		public Game_Chara_MenuUI_Base sModel;

		public Academy_TalkButton sButton;
	}

	[SerializeField]
	private Transform m_trFrontUIRoot;

	[SerializeField]
	private Transform m_trBackUIRoot;

	[SerializeField]
	private GameObject m_goTalkIconPrefab;

	[SerializeField]
	private Transform[] m_atrMemberRoot;

	[SerializeField]
	private Transform[] m_atrMemberSetRoot;

	[SerializeField]
	private Transform[] m_atrNPCRoot;

	private List<LocInfo> m_vLocInfo;

	private List<MasterQuestInfo> GetOrderQuestList()
	{
		return null;
	}

	public void Init(bool update = false)
	{
	}

	public void UpdateEquip()
	{
	}

	public void UpdateTalk()
	{
	}

	public bool IsNeedUpdate()
	{
		return false;
	}

	public void SetTalkIcon(bool enable)
	{
	}

	public void StopRandomVoice()
	{
	}

	[DebuggerHidden]
	private IEnumerator InitLocation(bool update)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator CreateModel(int charaDF, Transform root, int motionID = 4)
	{
		return null;
	}
}
