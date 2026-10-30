using Tutorial;
using UnityEngine;

public class TutorialCommandADV : TutorialCommandBase
{
	private bool m_bShowErrorDialog;

	public override void Exec(Data clsData)
	{
		if (clsData == null) return;
		string scriptPath = clsData.GetParam(0);
		Debug.Log("[TutorialCommandADV] Exec ADV script: " + scriptPath);
		ADV.ADVManager.Load(scriptPath);
	}

	public override bool IsEnd()
	{
		if (ADV.ADVManager.IsAlmostEnd)
		{
			if (ADV.ADVManager.IsError)
			{
				if (!m_bShowErrorDialog)
				{
					m_bShowErrorDialog = true;
					DialogCommon.CreateOKDialog("ADV Error", OnADVErrorDialog);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private void OnADVErrorDialog(EButtonKind eResult)
	{
		if (TutorialManager.Instance != null)
		{
			TutorialManager.Instance.ForceEnd();
		}
	}
}
