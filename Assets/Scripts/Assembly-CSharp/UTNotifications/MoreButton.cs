using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace UTNotifications
{
	public class MoreButton : MonoBehaviour
	{
		[StructLayout((LayoutKind)0, Size = 16)]
		public struct PopupMenuItem
		{
			public readonly string label;

			public readonly UnityAction action;

			public PopupMenuItem(string label, UnityAction action)
			{
				this.label = null;
				this.action = null;
			}
		}

		public GameObject PopupPrefab;

		public PopupMenuItem[] MenuItems;

		private GameObject popup;

		public static MoreButton FindInstance()
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnClick()
		{
		}
	}
}
