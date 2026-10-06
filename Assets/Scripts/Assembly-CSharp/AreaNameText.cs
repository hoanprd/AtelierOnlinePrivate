using System.Collections.Generic;
using UnityEngine;

public class AreaNameText : MonoBehaviour
{
	public enum eUIKind
	{
		Large = 0,
		Small = 1,
		EnumMax = 2
	}

	private bool m_bTimeResume;

	private List<float>[] m_fPlayTimeListArray;

	public AreaNameUI[] m_scrUIArray;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Play(string strTitle, string strSub, eUIKind eUI)
	{
	}

	public void Play(FieldName clsName)
	{
	}

	public void Play(eUIKind eUI)
	{
	}

	public void SetSpeed(float fSpeed, eUIKind eUI = eUIKind.EnumMax)
	{
	}

	public bool IsPlaying(eUIKind eUI = eUIKind.EnumMax)
	{
		return false;
	}

	public void SetDeactivate(eUIKind eUI = eUIKind.EnumMax)
	{
	}

	public void SetEndDeactive(eUIKind eUI, bool bDeactivate)
	{
	}
}
