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

	private bool m_bDestroy = true;

	private bool m_bBringin;

	private EButtonKind m_eResult;

	private bool m_bCheckTutorialMask = true;

	protected Action<EButtonKind> m_sCallback;

	private static int siDispCount;

	public string Subject
	{
		set
		{
			if (m_sSubject != null)
			{
				m_sSubject.text = value;
			}
		}
	}

	public string Content
	{
		set
		{
			if (m_sLabel != null)
			{
				m_sLabel.text = value;
			}
		}
	}

	public static bool IsDisp()
	{
		return siDispCount > 0;
	}

	private void OnEnable()
	{
		siDispCount++;
	}

	private void OnDisable()
	{
		siDispCount = Mathf.Max(0, siDispCount - 1);
	}

	public void OnDecide(DialogButton btn)
	{
		if (btn == null)
		{
			return;
		}
		m_eResult = btn.Type;
		Dismiss();
		if (Sound_Manager.GetInst() != null)
		{
			if (btn.Type == EButtonKind.eCANCEL)
			{
				Sound_Manager.GetInst().PlaySound(eSoundID.system_003);
			}
			else if (btn.Type == EButtonKind.eDECIDE)
			{
				Sound_Manager.GetInst().PlaySound(eSoundID.system_002);
			}
			else
			{
				Sound_Manager.GetInst().PlaySound(eSoundID.system_000);
			}
		}
	}

	public void OnAnimationEnd()
	{
		if (m_bBringin)
		{
			m_bBringin = false;
			return;
		}
		if (m_bCheckTutorialMask && TutorialManager.IsExist)
		{
			TutorialManager.Instance.SetCameraMask();
		}
		if (m_sCallback != null)
		{
			m_sCallback(m_eResult);
		}
		if (m_bDestroy)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
		else
		{
			gameObject.SetActive(false);
		}
	}

	private void Start()
	{
		SetLayer(gameObject.layer);
		SetFrontDepth();
		if (m_bCheckTutorialMask && TutorialManager.IsExist)
		{
			if (TutorialManager.Instance.IsCameraMask())
			{
				TutorialManager.Instance.UndoCameraMask();
			}
			else
			{
				m_bCheckTutorialMask = false;
			}
		}
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound(eSoundID.system_005);
		}
	}

	public override void Bringin()
	{
		m_bBringin = true;
		gameObject.SetActive(true);
		if (m_sAnim != null)
		{
			m_sAnim.ResetTweenForward();
		}
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound(eSoundID.system_005);
		}
	}

	public override void Dismiss()
	{
		m_bBringin = false;
		Util.SetEnableButton(gameObject, false);
		if (m_sAnim != null)
		{
			m_sAnim.SetOnFinish(new EventDelegate(this, "OnAnimationEnd"));
			m_sAnim.ResetTweenReverse();
		}
		else
		{
			OnAnimationEnd();
		}
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound(eSoundID.system_003);
		}
	}

	public void SetButton(string name, EButtonKind type)
	{
		if (m_asButton != null)
		{
			for (int i = 0; i < m_asButton.Length; i++)
			{
				if (m_asButton[i] != null)
				{
					m_asButton[i].gameObject.SetActive(i == 0);
				}
			}
			if (m_asButton.Length > 0 && m_asButton[0] != null)
			{
				m_asButton[0].SetText(name, type);
			}
		}
		if (m_sButtonRoot != null)
		{
			m_sButtonRoot.repositionNow = true;
		}
	}

	public void SetButton(string name, EButtonKind type, string name2, EButtonKind type2)
	{
		if (m_asButton != null)
		{
			for (int i = 0; i < m_asButton.Length; i++)
			{
				if (m_asButton[i] != null)
				{
					m_asButton[i].gameObject.SetActive(i < 2);
				}
			}
			if (m_asButton.Length > 0 && m_asButton[0] != null)
			{
				m_asButton[0].SetText(name, type);
			}
			if (m_asButton.Length > 1 && m_asButton[1] != null)
			{
				m_asButton[1].SetText(name2, type2);
			}
		}
		if (m_sButtonRoot != null)
		{
			m_sButtonRoot.repositionNow = true;
		}
	}

	public void Init(string content, string button, Action<EButtonKind> callback)
	{
		m_eResult = EButtonKind.eNORMAL;
		if (m_sLabel != null)
		{
			m_sLabel.gameObject.SetActive(true);
			m_sLabel.text = content;
		}
		if (m_goTitleRoot != null)
		{
			m_goTitleRoot.SetActive(false);
		}
		if (m_goCloseButton != null)
		{
			m_goCloseButton.SetActive(false);
		}
		m_sCallback = callback;
		SetButton(button, EButtonKind.eDECIDE);
	}

	public void InitYesNo(string content, bool enableCancel, Action<EButtonKind> callback)
	{
		m_eResult = EButtonKind.eNORMAL;
		if (m_sLabel != null)
		{
			m_sLabel.gameObject.SetActive(true);
			m_sLabel.text = content;
		}
		if (m_goTitleRoot != null)
		{
			m_goTitleRoot.SetActive(false);
		}
		if (m_goCloseButton != null)
		{
			m_goCloseButton.SetActive(enableCancel);
		}
		m_sCallback = callback;
		SetButton("いいえ", EButtonKind.eCANCEL, "はい", EButtonKind.eDECIDE);
	}

	public void InitYesNo(string subject, string content, bool enableCancel, Action<EButtonKind> callback)
	{
		m_eResult = EButtonKind.eNORMAL;
		if (m_sLabel != null)
		{
			m_sLabel.gameObject.SetActive(false);
		}
		if (m_goTitleRoot != null)
		{
			m_goTitleRoot.SetActive(true);
		}
		if (m_sSubject != null)
		{
			m_sSubject.text = subject;
		}
		if (m_sSubjectContent != null)
		{
			m_sSubjectContent.text = content;
		}
		if (m_goCloseButton != null)
		{
			m_goCloseButton.SetActive(enableCancel);
		}
		m_sCallback = callback;
		SetButton("いいえ", EButtonKind.eCANCEL, "はい", EButtonKind.eDECIDE);
	}

	public void InitSimple(string subject, string content, Action<EButtonKind> callback)
	{
		m_eResult = EButtonKind.eNORMAL;
		if (m_sLabel != null)
		{
			m_sLabel.gameObject.SetActive(false);
		}
		if (m_goTitleRoot != null)
		{
			m_goTitleRoot.SetActive(true);
		}
		if (m_sSubject != null)
		{
			m_sSubject.text = subject;
		}
		if (m_sSubjectContent != null)
		{
			m_sSubjectContent.text = content;
		}
		m_sCallback = callback;
		if (m_asButton != null)
		{
			for (int i = 0; i < m_asButton.Length; i++)
			{
				if (m_asButton[i] != null)
				{
					m_asButton[i].gameObject.SetActive(false);
				}
			}
		}
	}

	public void InitSimple(string content, Action<EButtonKind> callback)
	{
		m_eResult = EButtonKind.eNORMAL;
		if (m_sLabel != null)
		{
			m_sLabel.gameObject.SetActive(true);
			m_sLabel.text = content;
		}
		if (m_goTitleRoot != null)
		{
			m_goTitleRoot.SetActive(false);
		}
		m_sCallback = callback;
		if (m_asButton != null)
		{
			for (int i = 0; i < m_asButton.Length; i++)
			{
				if (m_asButton[i] != null)
				{
					m_asButton[i].gameObject.SetActive(false);
				}
			}
		}
	}

	public void SetTutorial(EButtonKind needClick)
	{
		UIPanel panel = GetComponent<UIPanel>();
		int baseDepth = (panel != null) ? panel.depth : 100;
		if (m_asButton != null)
		{
			for (int i = 0; i < m_asButton.Length; i++)
			{
				if (m_asButton[i] != null && m_asButton[i].Type == needClick)
				{
					TutorialButton tb = NGUITools.AddMissingComponent<TutorialButton>(m_asButton[i].gameObject);
					if (tb != null)
					{
						tb.SetArrowPanelDepth(baseDepth + 1);
					}
				}
			}
		}
		m_bCheckTutorialMask = false;
	}

	private static DialogCommon InstantiateDialog()
	{
		UnityEngine.Object prefab = Resources.Load("UI/Dialog/Dialog_Common00");
		if (prefab == null)
		{
			return null;
		}
		GameObject go = UnityEngine.Object.Instantiate(prefab) as GameObject;
		if (go == null)
		{
			return null;
		}
		return go.GetComponent<DialogCommon>();
	}

	public static DialogCommon CreateYesNODialog(string content, Action<EButtonKind> callback)
	{
		DialogCommon dlg = InstantiateDialog();
		if (dlg != null)
		{
			dlg.InitYesNo(content, true, callback);
		}
		else if (callback != null)
		{
			callback(EButtonKind.eDECIDE);
		}
		return dlg;
	}

	public static DialogCommon CreateForceYesNODialog(string subject, string content, Action<EButtonKind> callback)
	{
		DialogCommon dlg = InstantiateDialog();
		if (dlg != null)
		{
			dlg.InitYesNo(subject, content, false, callback);
		}
		else if (callback != null)
		{
			callback(EButtonKind.eDECIDE);
		}
		return dlg;
	}

	public static DialogCommon CreateForceYesNODialog(string content, Action<EButtonKind> callback)
	{
		DialogCommon dlg = InstantiateDialog();
		if (dlg != null)
		{
			dlg.InitYesNo(content, false, callback);
		}
		else if (callback != null)
		{
			callback(EButtonKind.eDECIDE);
		}
		return dlg;
	}

	public static DialogCommon CreateCapacityOverDialog(InventoryList.Info info, Action<EButtonKind> callback = null)
	{
		int over = (info != null && info.RCK != null) ? (info.RCK.CNT - info.RCK.SZ) : 1;
		string msg = string.Format("[c][ff0000]{0}つ[-][/c]オーバーしています\r\n\r\nリュックを拡張するか、\r\nアイテムを捨てて、\r\nリュックに空きを作ってください。", over);
		DialogCommon dlg = InstantiateDialog();
		if (dlg != null)
		{
			dlg.InitYesNo("リュックがいっぱいです。", msg, false, callback);
			dlg.SetButton("OK", EButtonKind.eDECIDE);
		}
		else if (callback != null)
		{
			callback(EButtonKind.eDECIDE);
		}
		return dlg;
	}

	public static DialogCommon CreateOKDialog(string content, Action<EButtonKind> callback = null)
	{
		DialogCommon dlg = InstantiateDialog();
		if (dlg != null)
		{
			dlg.Init(content, "OK", callback);
		}
		else if (callback != null)
		{
			callback(EButtonKind.eDECIDE);
		}
		return dlg;
	}

	public static DialogCommon CreateDialog(string subject, string content, Action<EButtonKind> callback)
	{
		DialogCommon dlg = InstantiateDialog();
		if (dlg != null)
		{
			dlg.InitSimple(subject, content, callback);
			dlg.SetButton("OK", EButtonKind.eDECIDE);
		}
		else if (callback != null)
		{
			callback(EButtonKind.eDECIDE);
		}
		return dlg;
	}

	public static DialogCommon CreateYesNODialog(string subject, string content, Action<EButtonKind> callback)
	{
		DialogCommon dlg = InstantiateDialog();
		if (dlg != null)
		{
			dlg.InitYesNo(subject, content, true, callback);
		}
		else if (callback != null)
		{
			callback(EButtonKind.eDECIDE);
		}
		return dlg;
	}

	public static DialogCommon CreateDialog(string content, Action<EButtonKind> callback)
	{
		DialogCommon dlg = InstantiateDialog();
		if (dlg != null)
		{
			dlg.InitSimple(content, callback);
		}
		else if (callback != null)
		{
			callback(EButtonKind.eDECIDE);
		}
		return dlg;
	}

	public static DialogCommon CreateDialog(PopupInfo data, Action<EButtonKind> callback)
	{
		if (data == null)
		{
			return null;
		}
		DialogCommon dlg = InstantiateDialog();
		if (dlg == null)
		{
			if (callback != null)
			{
				callback(EButtonKind.eDECIDE);
			}
			return null;
		}
		if (data.BTN != null && data.BTN.Length == 1 && data.BTN[0] != null)
		{
			dlg.Init(data.MSG, data.BTN[0].NA, callback);
		}
		else if (data.BTN != null && data.BTN.Length >= 2 && data.BTN[0] != null && data.BTN[1] != null)
		{
			dlg.InitYesNo(data.CAP, data.MSG, false, callback);
			dlg.SetButton(data.BTN[1].NA, EButtonKind.eCANCEL, data.BTN[0].NA, EButtonKind.eDECIDE);
		}
		else
		{
			dlg.InitSimple(data.CAP, data.MSG, callback);
		}
		return dlg;
	}
}
