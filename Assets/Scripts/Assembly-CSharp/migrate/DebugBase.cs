using UnityEngine;

namespace migrate
{
	internal class DebugBase
	{
		public UIRoot m_ui_root;

		public Rigidbody m_rigid_body;

		public GameObject m_camera_gameobject;

		public Camera m_camera;

		public UICamera m_ui_camera;

		public GameObject m_top_gameobject;

		public UIPanel m_ui_panel;

		public Texture2D m_texture;

		public Vector2 m_center;

		public Vector2 m_size;

		public GameObject m_back;

		public UITexture m_back_ui_texture;

		public DebugBase(GameObject obj)
		{
		}

		private void CreateUIRoot()
		{
		}

		private void CreateCamera()
		{
		}

		public void SetSize(float width, float height)
		{
		}

		public void SetMask(float width, float height)
		{
		}
	}
}
