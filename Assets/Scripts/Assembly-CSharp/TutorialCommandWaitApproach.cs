using Tutorial;
using UnityEngine;

public class TutorialCommandWaitApproach : TutorialCommandBase
{
	private bool m_bApproach;

	private eExecKind m_eKind;

	private GameObject m_goWaitObj;

	private float m_fPlayerDist;

	private string m_strObjName;

	private Vector3 m_v3Target;

	public override void Exec(Data clsData)
	{
	}

	public override void Update()
	{
	}

	public override bool IsEnd()
	{
		return false;
	}
}
