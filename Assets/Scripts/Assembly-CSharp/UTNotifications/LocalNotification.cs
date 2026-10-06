using System.Collections.Generic;

namespace UTNotifications
{
	public class LocalNotification : Notification
	{
		public LocalNotification(string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
			: base(null, null, 0)
		{
		}

		public LocalNotification(string title, string text, int id)
			: base(null, null, 0)
		{
		}

		public LocalNotification(JSONNode json)
			: base(null, null, 0)
		{
		}

		public new LocalNotification SetUserData(IDictionary<string, string> userData)
		{
			return null;
		}

		public new LocalNotification SetNotificationProfile(string notificationProfile)
		{
			return null;
		}

		public new LocalNotification SetBadgeNumber(int badgeNumber)
		{
			return null;
		}

		public new LocalNotification SetButtons(ICollection<Button> buttons)
		{
			return null;
		}
	}
}
