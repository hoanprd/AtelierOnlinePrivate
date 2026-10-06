using System;
using UnityEngine;

public class DialogCommon : DialogBase
{
	public GameObject m_goTitleRoot;

	public UILabel m_sSubject;

	public UILabel m_sSubjectContent;

	public UILabel m_sLabel;

	public UIGrid m_sButtonRoot;

	public DialogButton[] m_asButton;

	public GameObject m_goCloseButton;

	public UITweenReset m_sAnim;

	public GameObject m_goBackGround;

	private int m_iDepth;

	private bool m_bDestroy;

	private bool m_bBringin;

	private EButtonKind m_eResult;

	private bool m_bCheckTutorialMask;

	protected Action<EButtonKind> m_sCallback;

	private static int siDispCount;

	public string Subject
	{
		set
		{
		}
	}

	public string Content
	{
		set
		{
		}
	}

	public static bool IsDisp()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnDecide(DialogButton btn)
	{
	}

	public void OnAnimationEnd()
	{
	}

	private void Start()
	{
	}

	public override void Bringin()
	{
	}

	public override void Dismiss()
	{
	}

	public void SetButton(string name, EButtonKind type)
	{
	}

	public void SetButton(string name, EButtonKind type, string name2, EButtonKind type2)
	{
	}

	public void Init(string content, string button, Action<EButtonKind> callback)
	{
	}

	public void InitYesNo(string content, bool enableCancel, Action<EButtonKind> callback)
	{
	}

	public void InitYesNo(string subject, string content, bool enableCancel, Action<EButtonKind> callback)
	{
	}

	public void InitSimple(string subject, string content, Action<EButtonKind> callback)
	{
	}

	public void InitSimple(string content, Action<EButtonKind> callback)
	{
	}

	public void SetTutorial(EButtonKind needClick)
	{
	}

	public static DialogCommon CreateYesNODialog(string content, Action<EButtonKind> callback)
	{
		return null;
	}

	public static DialogCommon CreateForceYesNODialog(string subject, string content, Action<EButtonKind> callback)
	{
		return null;
	}

	public static DialogCommon CreateForceYesNODialog(string content, Action<EButtonKind> callback)
	{
		return null;
	}

	public static DialogCommon CreateCapacityOverDialog(InventoryList.Info info, Action<EButtonKind> callback = null)
	{
		return null;
	}

	public static DialogCommon CreateOKDialog(string content, Action<EButtonKind> callback = null)
	{
		return null;
	}

	public static DialogCommon CreateDialog(string subject, string content, Action<EButtonKind> callback)
	{
		return null;
	}

	public static DialogCommon CreateYesNODialog(string subject, string content, Action<EButtonKind> callback)
	{
		return null;
	}

	public static DialogCommon CreateDialog(string content, Action<EButtonKind> callback)
	{
		return null;
	}

	public static DialogCommon CreateDialog(PopupInfo data, Action<EButtonKind> callback)
	{
		return null;
	}
}
