using UnityEngine;

namespace ADV
{
	public class LogWindow : MonoBehaviour
	{
		public UIButton m_sOpenButton;

		public UIButton m_sCloseButton;

		public UIScrollBar m_sScroll;

		public UIScrollView m_sScrollView;

		public UIPanel m_sPanel;

		public GameObject m_goButtonRoot;

		public GameObject m_goListObject;

		public UILabel m_sContent;

		public Color32 m_sNameColor;

		public Color32 m_sLineColor;

		public bool IsDisp
		{
			get
			{
				return false;
			}
		}

		public bool ButtonActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void UpdateScrollPosition()
		{
		}

		public void Init()
		{
		}

		public void AddContent(string name, string content)
		{
		}

		public void AddContent(string content)
		{
		}

		public void OnOpen()
		{
		}

		public void OnClose()
		{
		}

		private string GetColorText(string original, Color32 color)
		{
			return null;
		}
	}
}
