using System;
using UnityEngine;

public class ShopHomeManager : MonoBehaviour
{
	[SerializeField]
	private SpawnPrefabData m_sShopTop;

	[SerializeField]
	private SpawnPrefabData m_sGachaTop;

	private Action<bool> m_sCloseEvent;

	public void Init(ShopMenuBase.EKind kind = ShopMenuBase.EKind.eGACHA, Action<bool> onClose = null, bool isRestart = false)
	{
	}

	private void OnClose(bool dispBadge)
	{
	}

	private void OnDisable()
	{
	}
}
