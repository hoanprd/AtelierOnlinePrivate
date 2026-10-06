using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class InventoryIcon : MonoBehaviour
{
	[SerializeField]
	private List<UISprite> m_vsIcon;

	private EStorageKind m_eNowKind;

	private InventoryListManager.EInventoryEditKind m_eEditKind;

	private void Awake()
	{
	}

	public void Change(EStorageKind kind, InventoryListManager.EInventoryEditKind edit)
	{
	}
}
