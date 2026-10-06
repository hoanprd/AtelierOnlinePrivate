using System.Collections.Generic;

namespace UTNotifications
{
	public class PushNotification : Notification
	{
		public readonly PushNotificationsProvider provider;

		public PushNotification(PushNotificationsProvider provider, string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
			: base(null, null, 0)
		{
		}

		public PushNotification(PushNotificationsProvider provider, string title, string text, int id)
			: base(null, null, 0)
		{
		}

		public PushNotification(JSONNode json)
			: base(null, null, 0)
		{
		}

		public override JSONClass ToJson()
		{
			return null;
		}

		public new PushNotification SetUserData(IDictionary<string, string> userData)
		{
			return null;
		}

		public new PushNotification SetNotificationProfile(string notificationProfile)
		{
			return null;
		}

		public new PushNotification SetBadgeNumber(int badgeNumber)
		{
			return null;
		}

		public new PushNotification SetButtons(ICollection<Button> buttons)
		{
			return null;
		}
	}
}
