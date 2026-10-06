using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
	private enum EStatus
	{
		eINIT = 0,
		eCONTROLL = 1,
		eCHANGE = 2
	}

	public static ShopManager SharedInstance;

	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private ShopMenuBase.EKind m_eStartKind;

	private EStatus m_eStatus;

	private List<ShopMenuBase> m_vMenuList;

	private ShopMenuBase m_sNowMenu;

	private ShopMenuBase.EKind m_eForceNext;

	private Action<bool> m_sOnExit;

	public static bool s_bUpdateLineup;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(Action<bool> onExit = null, bool isRestart = false)
	{
	}

	public void ForceExit()
	{
	}

	private void Bringin()
	{
	}

	private void Update()
	{
	}

	[DebuggerHidden]
	private IEnumerator MenuStart(ShopMenuBase.EKind next, Action didEnd = null, bool isRestart = false)
	{
		return null;
	}
}
