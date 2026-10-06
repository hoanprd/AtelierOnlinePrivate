using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class FairyPickResultOnce : UIListViewBase<BattleResultItemIcon>
{
	[SerializeField]
	private UILabel m_sTitle;

	[SerializeField]
	private GameObject m_goFairy;

	private bool m_bAnimEnd;

	private bool m_bRare;

	public bool IsAnimEnd
	{
		get
		{
			return false;
		}
	}

	public bool IsRare
	{
		get
		{
			return false;
		}
	}

	private void Awake()
	{
	}

	public void InitOne(FairyPickResult result)
	{
	}

	public void Init(FairyPickResult result)
	{
	}

	public void OpenStart()
	{
	}

	public void Skip()
	{
	}

	private void CreateItem(FairyPickResult result)
	{
	}

	private void AnimEnd()
	{
	}

	private void OnBoxOpen()
	{
	}

	[DebuggerHidden]
	private IEnumerator Open()
	{
		return null;
	}
}
