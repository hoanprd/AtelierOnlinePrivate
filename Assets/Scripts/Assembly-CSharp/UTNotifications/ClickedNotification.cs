using System.Collections.Generic;

namespace UTNotifications
{
	public class ClickedNotification : ReceivedNotification
	{
		public const int BUTTON_NONE = -1;

		public readonly int clickedButtonIndex;

		public override IDictionary<string, string> userData
		{
			get
			{
				return null;
			}
		}

		public ClickedNotification(Notification notification, int clickedButtonIndex)
			: base((Notification)null)
		{
		}

		public ClickedNotification(JSONNode json)
			: base((Notification)null)
		{
		}
	}
}
