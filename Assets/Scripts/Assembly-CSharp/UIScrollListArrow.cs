using System.Collections.Generic;
using UnityEngine;

public class UIScrollListArrow : MonoBehaviour
{
	public class HorizontalSort : IComparer<UIWidget>
	{
		public int Compare(UIWidget x, UIWidget y)
		{
			return 0;
		}
	}

	public class VerticalSort : IComparer<UIWidget>
	{
		public int Compare(UIWidget x, UIWidget y)
		{
			return 0;
		}
	}

	public UIScrollView m_sScrollView;

	public Transform m_trRoot;

	public GameObject m_goAddArrow;

	public GameObject m_goDecArrow;

	public UIWidget m_sMaxObject;

	public UIWidget m_sMinObject;

	private bool m_bUpdate;

	public void Disable()
	{
	}

	public void Reset()
	{
	}

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}
}
