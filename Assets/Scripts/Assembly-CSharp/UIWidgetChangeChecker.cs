using System;
using UnityEngine;

public class UIWidgetChangeChecker : MonoBehaviour
{
	[Serializable]
	public class WidgetInfo
	{
		public UIWidget widget;

		public Color prevColor;

		public Transform prevPosition;
	}

	[SerializeField]
	private bool m_bInChild;

	[SerializeField]
	private WidgetInfo[] m_asInfo;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
