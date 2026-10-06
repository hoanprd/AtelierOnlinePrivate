using System.Collections.Generic;
using UnityEngine;

namespace migrate
{
	internal class DebugGameObject : MonoBehaviour
	{
		private static Texture2D m_hide_texture;

		private static Texture2D m_display_texture;

		public int m_child_no;

		public string m_name;

		public UILabel m_label;

		public string m_value;

		public bool m_has_child;

		public bool m_hide;

		public List<GameObject> m_children;

		public GameObject m_text_gameobject;

		public GameObject m_hide_icon_gameobject;

		public UITexture m_hide_icon_texture;

		public UIInput m_input;

		public BoxCollider2D m_box_collider;

		public UIButton m_button;

		public EventDelegate m_on_click;

		public EventDelegate m_on_input;

		public void Init(string name, string value)
		{
		}

		public void UpdateValue(string value)
		{
		}

		public void AddChild(GameObject obj)
		{
		}

		public void OnClickButton()
		{
		}

		private void MakeTexture()
		{
		}

		private void CreateIcon()
		{
		}

		private void SetDisplayModeIcon()
		{
		}

		private void SetHideModeIcon()
		{
		}

		public void OnInputMessage()
		{
		}

		public int GetActiveChildrenNum()
		{
			return 0;
		}

		public void FairPosition()
		{
		}
	}
}
