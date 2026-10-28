using System.Collections.Generic;
using UnityEngine;

public class InformationManager : SingletonBase<InformationManager>
{
	protected enum EStep
	{
		eWAIT = 0,
		eBRINGIN = 1,
		eDISP = 2,
		eDISMISS = 3
	}

	public class Data
	{
		public string sContent;

		public int iGroup;
	}

	public float m_fDispDelay = 0.1f;

	public float m_fWaitTime = 1f;

	public GameObject m_goLabelRoot;

	public UITweenReset m_sAnim;

	public UILabel m_sLabel;

	private List<Data> m_vContentList = new List<Data>();

	private EStep m_eStep;

	private float m_fTimer;

	public bool IsMove
	{
		get
		{
			return (m_vContentList != null && m_vContentList.Count > 0) || m_eStep != EStep.eWAIT;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		if (m_goLabelRoot != null)
		{
			m_goLabelRoot.SetActive(false);
		}
	}

	public void Clear(int group)
	{
		if (m_vContentList != null)
		{
			m_vContentList.RemoveAll((Data d) => d != null && d.iGroup == group);
		}
	}

	public void Clear(bool all = true)
	{
		if (m_vContentList != null)
		{
			if (all)
			{
				m_vContentList.Clear();
			}
			else if (m_vContentList.Count > 1)
			{
				m_vContentList.RemoveRange(1, m_vContentList.Count - 1);
			}
		}
		if (all)
		{
			m_eStep = EStep.eWAIT;
			m_fTimer = 0f;
			if (m_goLabelRoot != null)
			{
				m_goLabelRoot.SetActive(false);
			}
		}
	}

	public void Init(string msg, int group = 0)
	{
		if (string.IsNullOrEmpty(msg))
		{
			return;
		}
		if (m_vContentList == null)
		{
			m_vContentList = new List<Data>();
		}
		m_vContentList.Add(new Data
		{
			sContent = msg,
			iGroup = group
		});
	}

	public void OnAnimEnd()
	{
		if (m_eStep == EStep.eBRINGIN)
		{
			m_eStep = EStep.eDISP;
			m_fTimer = 0f;
		}
		else if (m_eStep == EStep.eDISMISS)
		{
			if (m_vContentList != null && m_vContentList.Count > 0)
			{
				m_vContentList.RemoveAt(0);
			}
			m_eStep = EStep.eWAIT;
			m_fTimer = 0f;
			if (m_goLabelRoot != null)
			{
				m_goLabelRoot.SetActive(false);
			}
		}
	}

	private void Update()
	{
		if (m_vContentList == null)
		{
			return;
		}
		switch (m_eStep)
		{
		case EStep.eWAIT:
			if (m_vContentList.Count > 0)
			{
				m_fTimer += Time.deltaTime;
				if (m_fTimer >= m_fDispDelay)
				{
					m_fTimer = 0f;
					if (m_sLabel != null)
					{
						m_sLabel.text = m_vContentList[0].sContent;
					}
					if (m_goLabelRoot != null)
					{
						m_goLabelRoot.SetActive(true);
					}
					if (m_sAnim != null)
					{
						m_sAnim.ResetTweenForward();
						m_eStep = EStep.eBRINGIN;
					}
					else
					{
						m_eStep = EStep.eDISP;
					}
				}
			}
			break;
		case EStep.eBRINGIN:
			m_fTimer += Time.deltaTime;
			if (m_fTimer >= 0.35f)
			{
				OnAnimEnd();
			}
			break;
		case EStep.eDISP:
			m_fTimer += Time.deltaTime;
			if (m_fTimer >= m_fWaitTime)
			{
				m_fTimer = 0f;
				if (m_sAnim != null)
				{
					m_sAnim.ResetTweenReverse();
					m_eStep = EStep.eDISMISS;
				}
				else
				{
					m_eStep = EStep.eDISMISS;
					OnAnimEnd();
				}
			}
			break;
		case EStep.eDISMISS:
			m_fTimer += Time.deltaTime;
			if (m_fTimer >= 0.35f)
			{
				OnAnimEnd();
			}
			break;
		}
	}
}
