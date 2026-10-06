using System;
using System.Collections.Generic;

namespace UTNotifications
{
	public class ScheduledRepeatingNotification : ScheduledNotification
	{
		public readonly int intervalSeconds;

		public override bool IsRepeating
		{
			get
			{
				return false;
			}
		}

		public ScheduledRepeatingNotification(DateTime triggerDateTime, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
			: base(default(DateTime), null, null, 0, null, null, 0, null)
		{
		}

		public ScheduledRepeatingNotification(DateTime triggerDateTime, int intervalSeconds, string title, string text, int id)
			: base(default(DateTime), null, null, 0, null, null, 0, null)
		{
		}

		public ScheduledRepeatingNotification(JSONNode json)
			: base(default(DateTime), null, null, 0, null, null, 0, null)
		{
		}

		public override JSONClass ToJson()
		{
			return null;
		}

		public new ScheduledRepeatingNotification SetUserData(IDictionary<string, string> userData)
		{
			return null;
		}

		public new ScheduledRepeatingNotification SetNotificationProfile(string notificationProfile)
		{
			return null;
		}

		public new ScheduledRepeatingNotification SetBadgeNumber(int badgeNumber)
		{
			return null;
		}

		public new ScheduledRepeatingNotification SetButtons(ICollection<Button> buttons)
		{
			return null;
		}
	}
}
