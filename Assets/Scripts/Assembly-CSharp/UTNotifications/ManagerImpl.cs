using System.Collections.Generic;

namespace UTNotifications
{
	public class ManagerImpl : Manager
	{
		private bool m_willHandleReceivedNotifications;

		private const float m_timeBetweenCheckingForIncomingNotifications = 0.5f;

		private float m_timeToCheckForIncomingNotifications;

		protected override bool InitializeImpl(bool willHandleReceivedNotifications, int startId = 0, bool incrementalId = false)
		{
			return false;
		}

		protected override void PostLocalNotificationImpl(LocalNotification notification)
		{
		}

		protected override void ScheduleNotificationImpl(ScheduledNotification notification)
		{
		}

		protected override void ScheduleNotificationRepeatingImpl(ScheduledRepeatingNotification notification)
		{
		}

		public override bool NotificationsEnabled()
		{
			return false;
		}

		public override bool NotificationsAllowed()
		{
			return false;
		}

		public override void SetNotificationsEnabled(bool enabled)
		{
		}

		public override bool PushNotificationsEnabled()
		{
			return false;
		}

		public override bool SetPushNotificationsEnabled(bool enabled)
		{
			return false;
		}

		protected override void CancelNotificationImpl(int id)
		{
		}

		public override void HideNotification(int id)
		{
		}

		public override void HideAllNotifications()
		{
		}

		protected override void CancelAllNotificationsImpl()
		{
		}

		public override int GetBadge()
		{
			return 0;
		}

		public override void SetBadge(int bandgeNumber)
		{
		}

		public override void SubscribeToTopic(string topic)
		{
		}

		public override void UnsubscribeFromTopic(string topic)
		{
		}

		protected override bool CleanupObsoleteScheduledNotifications(List<ScheduledNotification> scheduledNotifications)
		{
			return false;
		}

		public void _OnAndroidIdReceived(string providerAndId)
		{
		}

		public void _OnAndroidPushRegistrationFailed(string error)
		{
		}

		protected void LateUpdate()
		{
		}

		protected void OnApplicationQuit()
		{
		}

		private void HandleClickedNotification(string receivedNotificationPacked)
		{
		}

		private void HandleReceivedNotifications(string receivedNotificationsPacked)
		{
		}

		private static ReceivedNotification ParseReceivedNotification(JSONNode json, bool clicked)
		{
			return null;
		}

		private static string ProfilesSettingsJson()
		{
			return null;
		}

		private static string ToString(object o)
		{
			return null;
		}

		private static string ToBase64(string str)
		{
			return null;
		}
	}
}
