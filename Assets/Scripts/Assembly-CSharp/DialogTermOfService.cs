using System;
using UnityEngine;

public class DialogTermOfService : UIWindowBase
{
	private EButtonKind m_eResult = EButtonKind.eCANCEL;

	private Action<EButtonKind> m_sResultEvent;

	[SerializeField]
	private UILabel m_sText;

	public void Init(Action<EButtonKind> onResult, bool isUpdate)
	{
		m_eResult = EButtonKind.eCANCEL;
		m_sResultEvent = onResult;
		if (isUpdate && m_sText != null)
		{
			m_sText.text = "[00897BFF]利用規約[904622FF]が変更されたため、\r\n再度同意する必要があります。";
		}
		Bringin();
	}

	public void OnDecide()
	{
		m_eResult = EButtonKind.eDECIDE;
		if (Sound_Manager.GetInst() != null)
		{
			Sound_Manager.GetInst().PlaySound(eSoundID.system_002);
		}
		OnClose();
	}

	public void OnDispTerms()
	{
		DialogCommon.CreateOKDialog("オフラインモードのため利用規約ページは表示されません。");
	}

	protected override void OnCloseEnd()
	{
		if (m_sResultEvent != null)
		{
			m_sResultEvent(m_eResult);
		}
		base.OnCloseEnd();
	}

	public static DialogTermOfService Create()
	{
		UnityEngine.Object prefab = Resources.Load("UI/Dialog/Dialog_TermsOfService");
		if (prefab == null)
		{
			return null;
		}
		GameObject go = UnityEngine.Object.Instantiate(prefab) as GameObject;
		if (go == null)
		{
			return null;
		}
		return go.GetComponent<DialogTermOfService>();
	}
}
