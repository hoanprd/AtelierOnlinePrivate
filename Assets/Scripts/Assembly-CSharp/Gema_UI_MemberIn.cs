using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Gema_UI_MemberIn : MonoBehaviour
{
	[SerializeField]
	private UILabel m_CharaName;

	[SerializeField]
	private UITexture m_CharaAllTexture;

	[SerializeField]
	private UITexture m_CharaShadow;

	[SerializeField]
	private UIButton m_Button;

	[SerializeField]
	private AnimationController m_Animation;

	private List<int> m_List;

	private int m_Count;

	private Sound_OneShot m_Voice;

	private AssetDownloader m_Downloader;

	private static bool sbDisp;

	public static bool IsDisp()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void TextBlend()
	{
	}

	public void Init(List<int> list)
	{
	}

	[DebuggerHidden]
	private IEnumerator Exec(int df)
	{
		return null;
	}

	public void End()
	{
	}

	[DebuggerHidden]
	private IEnumerator EndObservation()
	{
		return null;
	}

	public static Gema_UI_MemberIn Create(Transform root)
	{
		return null;
	}
}
