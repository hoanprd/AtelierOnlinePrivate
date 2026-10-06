using System;
using System.Collections.Generic;
using UnityEngine;

namespace UTNotifications
{
	public abstract class Manager : MonoBehaviour
	{
		public delegate void OnInitializedHandler();

		public delegate void OnSendRegistrationIdHandler(string providerName, string registrationId);

		public delegate void OnPushRegistrationFailedHandler(string error);

		public delegate void OnNotificationClickedHandler(ReceivedNotification notification);

		public delegate void OnNotificationsReceivedHandler(IList<ReceivedNotification> receivedNotifications);

		private OnInitializedHandler OnInitialized__BackingField;

		private OnSendRegistrationIdHandler OnSendRegistrationId__BackingField;

		private OnPushRegistrationFailedHandler OnPushRegistrationFailed__BackingField;

		private OnNotificationClickedHandler OnNotificationClicked__BackingField;

		private OnNotificationsReceivedHandler OnNotificationsReceived__BackingField;

		private static readonly string SCHEDULED_NOTIFICATIONS_PREFS_KEY;

		private static Manager m_instance;

		private static bool m_destroyed;

		private bool m_initialized;

		private readonly List<ScheduledNotification> m_scheduledNotifications;

		public static Manager Instance
		{
			get
			{
				return null;
			}
		}

		public bool Initialized
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public ICollection<ScheduledNotification> ScheduledNotifications
		{
			get
			{
				return null;
			}
		}

		public event OnInitializedHandler OnInitialized
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnSendRegistrationIdHandler OnSendRegistrationId
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnPushRegistrationFailedHandler OnPushRegistrationFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnNotificationClickedHandler OnNotificationClicked
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnNotificationsReceivedHandler OnNotificationsReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public bool Initialize(bool willHandleReceivedNotifications, int startId = 0, bool incrementalId = false)
		{
			return false;
		}

		public void PostLocalNotification(string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
		}

		public void PostLocalNotification(LocalNotification notification)
		{
		}

		public void ScheduleNotification(int triggerInSeconds, string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
		}

		public void ScheduleNotification(DateTime triggerDateTime, string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
		}

		public void ScheduleNotification(ScheduledNotification notification)
		{
		}

		public void ScheduleNotificationRepeating(int firstTriggerInSeconds, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
		}

		public void ScheduleNotificationRepeating(DateTime firstTriggerDateTime, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
		}

		public abstract bool NotificationsEnabled();

		public abstract bool NotificationsAllowed();

		public abstract void SetNotificationsEnabled(bool enabled);

		public abstract bool PushNotificationsEnabled();

		public abstract bool SetPushNotificationsEnabled(bool enable);

		public void CancelNotification(int id)
		{
		}

		public abstract void HideNotification(int id);

		public void CancelAllNotifications()
		{
		}

		public abstract void HideAllNotifications();

		public abstract int GetBadge();

		public abstract void SetBadge(int bandgeNumber);

		public abstract void SubscribeToTopic(string topic);

		public abstract void UnsubscribeFromTopic(string topic);

		protected abstract bool InitializeImpl(bool willHandleReceivedNotifications, int startId, bool incrementalId);

		protected abstract void PostLocalNotificationImpl(LocalNotification notification);

		protected abstract void ScheduleNotificationImpl(ScheduledNotification notification);

		protected abstract void ScheduleNotificationRepeatingImpl(ScheduledRepeatingNotification notification);

		protected abstract void CancelNotificationImpl(int id);

		protected abstract void CancelAllNotificationsImpl();

		protected abstract bool CleanupObsoleteScheduledNotifications(List<ScheduledNotification> scheduledNotifications);

		protected bool OnSendRegistrationIdHasSubscribers()
		{
			return false;
		}

		protected void _OnSendRegistrationId(string providerName, string registrationId)
		{
		}

		protected bool OnPushRegistrationHasSubscribers()
		{
			return false;
		}

		protected void _OnPushRegistrationFailed(string error)
		{
		}

		protected bool OnNotificationClickedHasSubscribers()
		{
			return false;
		}

		protected void _OnNotificationClicked(ReceivedNotification notification)
		{
		}

		protected bool OnNotificationsReceivedHasSubscribers()
		{
			return false;
		}

		protected void _OnNotificationsReceived(IList<ReceivedNotification> receivedNotifications)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected void NotSupported(string feature = null)
		{
		}

		protected bool CheckInitialized()
		{
			return false;
		}

		private static void InstanceRequired()
		{
		}

		private void CleanupObsoleteScheduledNotifications()
		{
		}

		private void CleanupReceivedScheduledNotification(List<ReceivedNotification> list)
		{
		}

		private void RegisterScheduledNotification(ScheduledNotification notification)
		{
		}

		private void UnregisterScheduledNotification(int id)
		{
		}

		private void UnregisterAllScheduledNotifications()
		{
		}

		private void SaveScheduledNotifications()
		{
		}

		private void LoadScheduledNotifications()
		{
		}
	}
}
