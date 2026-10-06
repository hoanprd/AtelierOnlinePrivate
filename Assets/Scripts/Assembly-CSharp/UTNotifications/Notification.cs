using System.Collections.Generic;

namespace UTNotifications
{
	public abstract class Notification
	{
		public const int BADGE_NOT_SPECIFIED = -1;

		public readonly string title;

		public readonly string text;

		public readonly int id;

		public IDictionary<string, string> userData { get; private set; }

		public string notificationProfile { get; private set; }

		public int badgeNumber { get; private set; }

		public ICollection<Button> buttons { get; private set; }

		public Notification(string title, string text, int id)
		{
		}

		public Notification(string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
		{
		}

		public Notification(JSONNode json)
		{
		}

		public virtual JSONClass ToJson()
		{
			return null;
		}

		public static Notification FromJson(JSONNode json)
		{
			return null;
		}

		public Notification SetUserData(IDictionary<string, string> userData)
		{
			return null;
		}

		public Notification SetNotificationProfile(string notificationProfile)
		{
			return null;
		}

		public Notification SetBadgeNumber(int badgeNumber)
		{
			return null;
		}

		public Notification SetButtons(ICollection<Button> buttons)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
