using System.Collections.Generic;

namespace UTNotifications
{
	public class ReceivedNotification
	{
		public Notification notification { get; private set; }

		public string title
		{
			get
			{
				return null;
			}
		}

		public string text
		{
			get
			{
				return null;
			}
		}

		public int id
		{
			get
			{
				return 0;
			}
		}

		public virtual IDictionary<string, string> userData
		{
			get
			{
				return null;
			}
		}

		public string notificationProfile
		{
			get
			{
				return null;
			}
		}

		public int badgeNumber
		{
			get
			{
				return 0;
			}
		}

		public ICollection<Button> buttons
		{
			get
			{
				return null;
			}
		}

		public ReceivedNotification(Notification notification)
		{
		}

		public ReceivedNotification(JSONNode json)
		{
		}
	}
}
