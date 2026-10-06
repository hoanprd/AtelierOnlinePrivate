using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ShopComLineupItem : MonoBehaviour
{
	[SerializeField]
	private Transform m_trDetailWindowRoot;

	private ItemBar m_sItemBar;

	private ShopComDetail.Item m_sInfo;

	private PresentWealthInfo m_sWealthInfo;

	public void Init(ShopComDetail.Item item)
	{
	}

	public void Init(PresentWealthInfo item)
	{
	}

	public void OnDetail(ItemBar target)
	{
	}

	[DebuggerHidden]
	private IEnumerator CheckDetailClose(GameObject wnd)
	{
		return null;
	}
}
