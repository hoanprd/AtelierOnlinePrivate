using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	public class NotificationDetailsDialog : MonoBehaviour
	{
		public Text DialogTitle;

		public Text ID;

		public Text Title;

		public Text Text;

		public Text Profile;

		public Text UserData;

		public Text Badge;

		private readonly List<ReceivedNotification> received;

		private ReceivedNotification clicked;

		public ReceivedNotification Current
		{
			get
			{
				return null;
			}
		}

		public void OnReceived(ReceivedNotification received)
		{
		}

		public void OnClicked(ReceivedNotification clicked)
		{
		}

		public void Hide()
		{
		}

		public void Hide(int id)
		{
		}

		public void Cancel()
		{
		}

		public void CancelAll()
		{
		}

		private void Start()
		{
		}

		private void UpdateContents()
		{
		}

		private string UserDataString(IDictionary<string, string> userData)
		{
			return null;
		}
	}
}
