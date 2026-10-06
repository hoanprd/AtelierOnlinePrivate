using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UTNotifications
{
	public class Settings : ScriptableObject
	{
		[Serializable]
		[StructLayout((LayoutKind)0, Size = 96)]
		public struct NotificationProfile
		{
			public string profileName;

			public string iosSound;

			public string androidChannelName;

			public string androidChannelDescription;

			public string androidIcon;

			public string androidLargeIcon;

			public string androidIcon5Plus;

			public bool colorSpecified;

			public Color androidColor;

			public string androidSound;

			public bool androidHighPriority;
		}

		public enum ShowNotifications
		{
			WHEN_CLOSED_OR_IN_BACKGROUND = 0,
			WHEN_CLOSED = 1,
			ALWAYS = 2
		}

		public enum NotificationsGroupingMode
		{
			NONE = 0,
			BY_NOTIFICATION_PROFILES = 1,
			FROM_USER_DATA = 2,
			ALL_IN_A_SINGLE_GROUP = 3
		}

		public enum ScheduleTimerType
		{
			RTC_WAKEUP = 0,
			RTC = 1,
			ELAPSED_REALTIME_WAKEUP = 2,
			ELAPSED_REALTIME = 3
		}

		public enum GooglePlayUpdatingIfRequiredMode
		{
			DISABLED = 0,
			ONCE = 1,
			EVERY_INITIALIZE = 2
		}

		private class UpdateMessage
		{
			public readonly string version;

			public readonly string text;

			public UpdateMessage(string version, string text)
			{
			}
		}

		public const string Version = "1.8.4";

		public const string DEFAULT_PROFILE_NAME = "default";

		public const string DEFAULT_PROFILE_NAME_INTERNAL = "__default_profile";

		[SerializeField]
		private List<NotificationProfile> m_notificationProfiles;

		[SerializeField]
		private string m_pushPayloadTitleFieldName;

		[SerializeField]
		private string m_pushPayloadTextFieldName;

		[SerializeField]
		private string m_pushPayloadIdFieldName;

		[SerializeField]
		private string m_pushPayloadUserDataParentFieldName;

		[SerializeField]
		private string m_pushPayloadNotificationProfileFieldName;

		[SerializeField]
		private string m_pushPayloadBadgeFieldName;

		[SerializeField]
		private string m_pushPayloadButtonsParentName;

		[SerializeField]
		private string m_googlePlayServicesLibVersion;

		private static readonly string m_googlePlayServicesLibVersionMin;

		[SerializeField]
		private string m_androidLegacySupportLibVersion;

		private static readonly string m_androidLegacySupportLibVersionMin;

		[SerializeField]
		private string m_shortcutBadgerVersion;

		private static readonly string m_shortcutBadgerVersionMin;

		[SerializeField]
		private ShowNotifications m_androidShowNotificationsMode;

		[SerializeField]
		private bool m_android4CompatibilityMode;

		[SerializeField]
		private bool m_androidRestoreScheduledNotificationsAfterReboot;

		[SerializeField]
		private NotificationsGroupingMode m_androidNotificationsGrouping;

		[SerializeField]
		private ScheduleTimerType m_androidScheduleTimerType;

		[SerializeField]
		private bool m_androidShowLatestNotificationOnly;

		[SerializeField]
		private bool m_androidScheduleExact;

		[SerializeField]
		private bool m_pushNotificationsEnabledIOS;

		[SerializeField]
		private bool m_pushNotificationsEnabledFirebase;

		[SerializeField]
		private bool m_pushNotificationsEnabledAmazon;

		[SerializeField]
		private bool m_pushNotificationsEnabledWindows;

		[SerializeField]
		private GooglePlayUpdatingIfRequiredMode m_allowUpdatingGooglePlayIfRequired;

		[SerializeField]
		private string m_assetVersionSaved;

		[SerializeField]
		private bool m_windowsDontShowWhenRunning;

		private const string m_assetName = "UTNotificationsSettings";

		private const string m_settingsMenuItem = "Edit/Project Settings/UTNotifications";

		private static Settings m_instance;

		public static Settings Instance
		{
			get
			{
				return null;
			}
		}

		public List<NotificationProfile> NotificationProfiles
		{
			get
			{
				return null;
			}
		}

		public string PushPayloadTitleFieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PushPayloadTextFieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PushPayloadIdFieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PushPayloadUserDataParentFieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PushPayloadNotificationProfileFieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PushPayloadBadgeFieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PushPayloadButtonsParentName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string GooglePlayServicesLibVersionMin
		{
			get
			{
				return null;
			}
		}

		public string GooglePlayServicesLibVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AndroidLegacySupportLibVersionMin
		{
			get
			{
				return null;
			}
		}

		public string AndroidLegacySupportLibVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ShortcutBadgerVersionMin
		{
			get
			{
				return null;
			}
		}

		public string ShortcutBadgerVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool PushNotificationsEnabledIOS
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool PushNotificationsEnabledFirebase
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool PushNotificationsEnabledAmazon
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool PushNotificationsEnabledWindows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ShowNotifications AndroidShowNotificationsMode
		{
			get
			{
				return ShowNotifications.WHEN_CLOSED_OR_IN_BACKGROUND;
			}
			set
			{
			}
		}

		public bool AndroidRestoreScheduledNotificationsAfterReboot
		{
			get
			{
				return false;
			}
		}

		public NotificationsGroupingMode AndroidNotificationsGrouping
		{
			get
			{
				return NotificationsGroupingMode.NONE;
			}
			set
			{
			}
		}

		public ScheduleTimerType AndroidScheduleTimerType
		{
			get
			{
				return ScheduleTimerType.RTC_WAKEUP;
			}
			set
			{
			}
		}

		public GooglePlayUpdatingIfRequiredMode AllowUpdatingGooglePlayIfRequired
		{
			get
			{
				return GooglePlayUpdatingIfRequiredMode.DISABLED;
			}
			set
			{
			}
		}

		public bool AndroidShowLatestNotificationOnly
		{
			get
			{
				return false;
			}
		}

		public bool AndroidScheduleExact
		{
			get
			{
				return false;
			}
		}

		public bool WindowsDontShowWhenRunning
		{
			get
			{
				return false;
			}
		}
	}
}
