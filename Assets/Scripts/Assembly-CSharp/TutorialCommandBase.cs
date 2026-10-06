using Tutorial;
using UnityEngine;

public class TutorialCommandBase : MonoBehaviour
{
	protected bool m_bDialogEnd;

	public virtual void Exec(Data clsData)
	{
	}

	public virtual void Update()
	{
	}

	public virtual bool IsEnd()
	{
		return false;
	}

	protected void MakeDialog(string strTitle, string strMessage, string strButtonName = "")
	{
	}

	protected virtual void OnDialogCommon(EButtonKind eResult)
	{
	}
}
