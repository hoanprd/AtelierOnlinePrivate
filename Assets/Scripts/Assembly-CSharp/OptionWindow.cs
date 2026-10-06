using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class OptionWindow : UIWindowBase
{
	[SerializeField]
	private List<UIToggle> m_vControlToggle;

	[SerializeField]
	private UISlider m_sBGMVolume;

	[SerializeField]
	private GameObject m_goBGMMuteMark;

	[SerializeField]
	private UISlider m_sSEVolume;

	[SerializeField]
	private GameObject m_goSEMuteMark;

	[SerializeField]
	private UIToggle m_sAutoContainer;

	[SerializeField]
	private List<UIToggle> m_vTextEffectToggle;

	[SerializeField]
	private List<UIToggle> m_vResolutionToggle;

	[SerializeField]
	private UIToggle m_sPickupDirection;

	[SerializeField]
	private UIToggle m_sAutoPickBomb;

	[SerializeField]
	private UIToggle m_sUseContainerItem;

	public void OnChangeControlType(UIToggle target)
	{
	}

	public void OnChangeBGMVolume()
	{
	}

	public void OnChangeSEVolume()
	{
	}

	private void OnMoveEndSEVolume()
	{
	}

	public void OnSwitchAutoStore4Container()
	{
	}

	public void OnSwitchPickupDirection()
	{
	}

	public void OnSwitchAutoPickBomb()
	{
	}

	public void OnSwitchUseContainerItem()
	{
	}

	public void OnChangeTextEffect(UIToggle target)
	{
	}

	public void OnChangeResolution(UIToggle target)
	{
	}

	[DebuggerHidden]
	private IEnumerator ChangeResolution(EResolutionLevel level)
	{
		return null;
	}

	public void OnReset()
	{
	}

	public override void Bringin()
	{
	}

	protected override void OnCloseEnd()
	{
	}

	private void Awake()
	{
	}

	private void Init()
	{
	}

	private void OnResetConfirmResult(EButtonKind result)
	{
	}

	public static OptionWindow Create(Transform root = null)
	{
		return null;
	}
}
