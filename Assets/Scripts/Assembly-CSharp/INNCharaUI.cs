using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class INNCharaUI : MonoBehaviour
{
	private bool m_bEndHeal;

	private bool m_bEndDismiss;

	private MultiPlay_CharaMemberData m_clsMember;

	public UITexture m_scrCharaFace;

	public UILabel m_scrCharaName;

	public UISlider m_scrHPSlider;

	public UITweenReset m_scrInOutTween;

	public GameObject m_goHealEffect;

	private void SetHP(int iNowHP, int iMaxHP, bool bAnim)
	{
	}

	[DebuggerHidden]
	private IEnumerator HPSliderAnim(float fAfterVal)
	{
		return null;
	}

	private void OnEndDismiss()
	{
	}

	public void SetCharaData(MultiPlay_CharaMemberData clsMember)
	{
	}

	public void BringIn()
	{
	}

	public void Dismiss()
	{
	}

	public void StartHeal()
	{
	}

	public bool IsEndHeal()
	{
		return false;
	}

	public bool IsEndDismiss()
	{
		return false;
	}
}
