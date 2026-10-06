using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GuideTop : MonoBehaviour
{
	private static readonly string s_buttonSpriteNormal;

	private static readonly string s_buttonSpriteOrder;

	private float m_waitTime;

	private float m_width;

	private QuestDetail m_orderQuest;

	private readonly string m_notOrderMessage;

	private QuestOrderListWindow m_OrderWindow;

	[SerializeField]
	private GameObject m_guideObj;

	[SerializeField]
	private UILabel m_text1;

	[SerializeField]
	private UILabel m_text2;

	[SerializeField]
	private UISprite m_icon1;

	[SerializeField]
	private UISprite m_icon2;

	[SerializeField]
	private GameObject m_detailButton;

	[SerializeField]
	private UISprite m_buttonSprite;

	[SerializeField]
	private UITweenReset m_buttonTween;

	[SerializeField]
	private UIPanel m_TextArea;

	private bool m_TextAreaFoldFlag;

	[SerializeField]
	private Vector4 m_TextAreaSizeIcon;

	[SerializeField]
	private Vector4 m_TextAreaSizeNotIcon;

	[SerializeField]
	private Vector3 m_forwardTextPosIcon;

	[SerializeField]
	private Vector3 m_forwardTextPosNotIcon;

	[SerializeField]
	private Vector3 m_backwardTextPos;

	private Vector3 m_text1EndPos;

	private Vector3 m_text2EndPos;

	private List<NoticeInfo> m_noticeInfoList;

	private int m_noticeInfoListIdx;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateGuideTop()
	{
	}

	public void UpdateGuideTopTutorial(EQuestGroup icon, string text)
	{
	}

	public void UpdateGuideTopTutorial(bool sw)
	{
	}

	[DebuggerHidden]
	private IEnumerator Scroll()
	{
		return null;
	}

	public void DetailButton()
	{
	}

	private void CreateRunningList()
	{
	}

	private void OnClose(List<QuestDetail> updateList)
	{
	}

	[DebuggerHidden]
	protected IEnumerator QuestCheck(List<QuestDetail> updateList)
	{
		return null;
	}

	public void OnSwitchOpen()
	{
	}

	private void SetUpQuestInfo()
	{
	}

	private void SetUpQuestInfo(string text, string icon)
	{
	}

	private void SetUpNoticeInfo()
	{
	}

	private void ResizeTextArea(bool isIcon)
	{
	}

	private void Move(UILabel targetLabel)
	{
	}

	private void Finish(UILabel targetLabel, UISprite targetIcon, NoticeInfo targetNoticeInfo)
	{
	}

	private void CheckDispCount(NoticeInfo target)
	{
	}

	private NoticeInfo UpdateContents(UILabel upTargetLabel, UISprite upTargetIcon, ref Vector3 upTargetEndPos)
	{
		return null;
	}

	private void SetDispContents(UILabel stTargetLabel, UISprite stTargetIcon, NoticeInfo dispNoticeInfo)
	{
	}

	private void AdjustEndPos(UISprite adTargetIcon, ref Vector3 adTargetEndPos)
	{
	}
}
