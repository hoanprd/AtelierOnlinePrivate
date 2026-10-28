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
		if (m_asInfo == null || m_asInfo.Length == 0)
		{
			UIWidget[] widgets = m_bInChild ? GetComponentsInChildren<UIWidget>(true) : GetComponents<UIWidget>();
			if (widgets != null && widgets.Length > 0)
			{
				m_asInfo = new WidgetInfo[widgets.Length];
				for (int i = 0; i < widgets.Length; i++)
				{
					m_asInfo[i] = new WidgetInfo
					{
						widget = widgets[i],
						prevColor = widgets[i] != null ? widgets[i].color : Color.white,
						prevPosition = widgets[i] != null ? widgets[i].transform : null
					};
				}
			}
		}
	}

	private void Update()
	{
		if (m_asInfo == null) return;
		for (int i = 0; i < m_asInfo.Length; i++)
		{
			WidgetInfo info = m_asInfo[i];
			if (info != null && info.widget != null && info.widget.color != info.prevColor)
			{
				info.prevColor = info.widget.color;
				info.widget.MarkAsChanged();
			}
		}
	}
}
