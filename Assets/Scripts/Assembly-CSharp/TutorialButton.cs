using System.Collections.Generic;
using Tutorial;
using UnityEngine;

public class TutorialButton : NGUI_ClickButton
{
	private static readonly float sr_fWaitChangeLayer;

	public static List<TutorialButton> s_scrButtonList;

	private GameObject m_goArrow;

	private int m_iOrgLayer;

	private bool m_bMaskLayer;

	private float m_fWaitChangeLayer;

	[SerializeField]
	private bool m_bIgnoreDecide;

	[SerializeField]
	private eTutorialCondition m_eDestroyCondition;

	[SerializeField]
	private string m_strDummyName;

	private string m_strButtonName
	{
		get
		{
			return null;
		}
	}

	public string DummyName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void AwakeSub()
	{
	}

	protected override void OnEnable_Sub()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void Init(bool bTutorial)
	{
	}

	protected override void DecideButton()
	{
	}

	private void ChangeLayer(bool bMask)
	{
	}

	private void MakeArrow()
	{
	}

	private void DestroyArrow()
	{
	}

	private bool IsTarget(bool bArrow)
	{
		return false;
	}

	public void SetIgnoreDecide(bool bIgnore)
	{
	}

	public void SetArrowPanelDepth(int iDepth)
	{
	}

	public static void UpdateMakeArrow()
	{
	}

	public static void UpdateDestroyArrow()
	{
	}
}
