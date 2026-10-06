using System.Collections.Generic;
using UnityEngine;

public class AlterKeywordDecideTitle : MonoBehaviour
{
	private enum EStep
	{
		eNONE = 0,
		ePLAY = 1,
		eWAIT = 2,
		eEND = 3
	}

	[SerializeField]
	private Animation m_sAnim;

	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private List<EventDelegate> m_sCallback;

	[SerializeField]
	private GameObject m_goParticle;

	private UIWidget[] m_asWidgets;

	private EStep m_eStep;

	private float m_fWait;

	private const float cfWAIT_TIME = 0.5f;

	public void Reset()
	{
	}

	public void Init(string name)
	{
	}

	private void LateUpdate()
	{
	}
}
