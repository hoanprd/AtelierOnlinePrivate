using System;
using UnityEngine;

public class FairyPickWindow : MonoBehaviour
{
	[SerializeField]
	private FairyPickManager m_sSelectWindow;

	[SerializeField]
	private FairyPickResultWindow m_sResultWindow;

	public void Init(FairyItemInfo[] param, Action<InventoryList> onCloseEnd)
	{
	}
}
