using System.Collections.Generic;
using UnityEngine;

public class AreaNameUI : MonoBehaviour
{
	private static readonly float sr_fReverseWaitTime;

	private UILabel[] m_scrTitleLabelArray;

	private List<float> m_fResumeTime;

	private bool m_bPlaying;

	private bool m_bDeactivate;

	private bool m_bReverse;

	private float m_fReverseWait;

	[SerializeField]
	private GameObject m_goRoot;

	[SerializeField]
	private Animation m_scrAnime;

	[SerializeField]
	private UIGrid m_scrGrid;

	[SerializeField]
	private UILabel m_scrSubLabel;

	[SerializeField]
	private bool m_bReverseOK;

	public void Init()
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void SetEndDeactive(bool bDeactivate)
	{
	}

	public void SetText(string strTitle, string strSub)
	{
	}

	public void Play()
	{
	}

	public void SetSpeed(float fSpeed)
	{
	}

	public void Suspend()
	{
	}

	public void Resume()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void SetDeactivate()
	{
	}

	public void Update()
	{
	}
}
