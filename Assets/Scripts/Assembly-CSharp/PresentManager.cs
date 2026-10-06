using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PresentManager : UIWrapListBase
{
	[SerializeField]
	private AnimationController[] m_asAnim;

	[SerializeField]
	private UILabel m_sSortName;

	[SerializeField]
	private UILabel m_sSelectToggle;

	[SerializeField]
	private UILabel m_sPresentNum;

	[SerializeField]
	private UIButton m_sReceiveButton;

	private Action<int> m_sOnClose;

	private bool m_bAllSelect;

	private bool m_bAscOrder;

	private PresentList m_sList;

	private List<long> m_viSelect;

	private List<long> m_viSend;

	private const string csSORT_KEY = "PRESENT_SORT";

	private const int ciDISP_ITEM_MAX = 4;

	private static readonly int REASON_DIFF_PF;

	private static readonly int REASON_OVER_LIMIT;

	private static readonly int REASON_UNKNOWN;

	private static readonly Dictionary<int, string> PRESENT_REASON_MAP;

	public void Init(ResponseDataCommon data, Action<int> onClose)
	{
	}

	private void OnReceiveReceive(PresentReceiveResponse res)
	{
	}

	private string CreateReceivedMessage(List<PresentReceiveData> prdList)
	{
		return null;
	}

	protected override void InitItem(int index, GameObject target)
	{
	}

	private void OnCloseEnd()
	{
	}

	public void OnClose()
	{
	}

	public void OnSortSwitch()
	{
	}

	private int OnCustomSort(PresentInfo x, PresentInfo y)
	{
		return 0;
	}

	public void OnSwitchSelect(PresentListItem item)
	{
	}

	public void OnAll()
	{
	}

	public void OnReceive(PresentListItem item)
	{
	}

	public void OnSelectReceive()
	{
	}

	[DebuggerHidden]
	private IEnumerator SelectReceive()
	{
		return null;
	}
}
