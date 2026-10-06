using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class Prologue : MonoBehaviour
{
	private bool m_bOutAnim;

	private bool m_bEnd;

	[SerializeField]
	private AnimationController m_scrInOutAnim;

	[SerializeField]
	private AnimationController m_scrTextAnim;

	[SerializeField]
	private UILongTapButton m_scrLongTap;

	[SerializeField]
	private GameObject m_goBlack;

	[SerializeField]
	private UIButton m_scrNextBtn;

	[SerializeField]
	private float m_fSkipSpeed;

	private void Awake()
	{
	}

	private void OnInAnimEnd()
	{
	}

	private void OnOutAnimEnd()
	{
	}

	private void OnTextAnimEnd()
	{
	}

	private void OnLongTap()
	{
	}

	private void OnRelease()
	{
	}

	private void OnNext()
	{
	}

	private void Skip(bool bSkip)
	{
	}

	private void Dismiss()
	{
	}

	[DebuggerHidden]
	private IEnumerator LastFadeIn()
	{
		return null;
	}

	private void ChangeLayer(Transform trParent, int iLayer)
	{
	}

	public void Play()
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void Kill()
	{
	}

	public static Prologue Create(GameObject goParent)
	{
		return null;
	}
}
