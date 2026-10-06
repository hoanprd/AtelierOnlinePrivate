using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AutoPickUI : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goLabelRoot;

	[SerializeField]
	private UILabel m_sLabel;

	[SerializeField]
	private UIToggle m_sToggle;

	[SerializeField]
	private UIButton m_sButton;

	[SerializeField]
	private UITweenReset m_sTween;

	private string m_sOrgText;

	private bool m_bAutoPick;

	private DebugAllPick m_sAutoPick;

	private List<EventDelegate> m_dToggleDelList;

	public void On()
	{
	}

	public void Off()
	{
	}

	public bool IsAutoPick()
	{
		return false;
	}

	public void Init()
	{
	}

	public void PlayTween(bool bForward)
	{
	}

	public void StopTween()
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public void StopPick()
	{
	}

	public void UseBomb(bool bUse)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnChange()
	{
	}

	private void OnClick()
	{
	}

	private void SetAutoPick(bool bStart)
	{
	}

	private void OnAutoPickEnd()
	{
	}

	[DebuggerHidden]
	private IEnumerator TextAnim()
	{
		return null;
	}
}
