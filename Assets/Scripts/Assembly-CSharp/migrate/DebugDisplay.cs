using System.Collections.Generic;
using UnityEngine;

namespace migrate
{
	internal class DebugDisplay : MonoBehaviour
	{
		private DebugBase m_base;

		private UICamera m_camera;

		private Dictionary<string, GameObject> m_manage_data;

		private GameObject m_debug_top;

		private DebugGameObject m_debug_game_object_top;

		private static GameObject s_gameobject;

		private static DebugDisplay s_instance;

		public static DebugDisplay GetInstance()
		{
			return null;
		}

		private static string GetCreateName(string name)
		{
			return null;
		}

		private static GameObject FindParent(string name)
		{
			return null;
		}

		public static void Add(string name, string value)
		{
		}

		public static bool Update(string name, string value)
		{
			return false;
		}

		public static bool GetValue(string name, out string value, string error)
		{
			value = null;
			return false;
		}

		public static bool GetBoolValue(string name, out bool value, bool error)
		{
			value = default(bool);
			return false;
		}

		public static void Clear()
		{
		}

		private void Update()
		{
		}
	}
}
