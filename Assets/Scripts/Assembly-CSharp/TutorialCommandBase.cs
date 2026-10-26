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
        return m_bDialogEnd;
    }

    protected void MakeDialog(string strTitle, string strMessage, string strButtonName = "")
    {
        m_bDialogEnd = false;

        DialogCommon dlg;
        if (string.IsNullOrEmpty(strTitle))
        {
            dlg = DialogCommon.CreateOKDialog(strMessage, OnDialogCommon);
        }
        else
        {
            dlg = DialogCommon.CreateDialog(strTitle, strMessage, OnDialogCommon);
        }

        if (dlg != null && !string.IsNullOrEmpty(strButtonName))
        {
            dlg.SetButton(strButtonName, EButtonKind.eDECIDE);
        }
    }

    protected virtual void OnDialogCommon(EButtonKind eResult)
    {
        m_bDialogEnd = true;
    }
}