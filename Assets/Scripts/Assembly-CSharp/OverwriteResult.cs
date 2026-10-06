using System;
using UnityEngine;

public class OverwriteResult : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private Transform m_trItemDetailRoot;

	[SerializeField]
	private UIButton m_sOKButton;

	private ItemDetailWindow m_sDetailWindow;

	private Action m_sCallback;

	public void Init(InventoryInfo result, Action callback)
	{
	}

	public void OnDecide()
	{
	}

	private void OnAnimationEnd()
	{
	}

	private void OnEndAnimationEnd()
	{
	}
}
