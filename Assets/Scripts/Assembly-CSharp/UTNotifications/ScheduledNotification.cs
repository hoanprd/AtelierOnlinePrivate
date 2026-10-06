using System;
using System.Collections.Generic;

namespace UTNotifications
{
	public class ScheduledNotification : LocalNotification
	{
		public readonly DateTime triggerDateTime;

		public virtual bool IsRepeating
		{
			get
			{
				return false;
			}
		}

		public ScheduledNotification(DateTime triggerDateTime, string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
			: base(null, null, 0, null, null, 0, null)
		{
		}

		public ScheduledNotification(DateTime triggerDateTime, string title, string text, int id)
			: base(null, null, 0, null, null, 0, null)
		{
		}

		public ScheduledNotification(JSONNode json)
			: base(null, null, 0, null, null, 0, null)
		{
		}

		public override JSONClass ToJson()
		{
			return null;
		}

		public new ScheduledNotification SetUserData(IDictionary<string, string> userData)
		{
			return null;
		}

		public new ScheduledNotification SetNotificationProfile(string notificationProfile)
		{
			return null;
		}

		public new ScheduledNotification SetBadgeNumber(int badgeNumber)
		{
			return null;
		}

		public new ScheduledNotification SetButtons(ICollection<Button> buttons)
		{
			return null;
		}

		private static DateTime ParseDateTime(string value)
		{
			return default(DateTime);
		}
	}
}
