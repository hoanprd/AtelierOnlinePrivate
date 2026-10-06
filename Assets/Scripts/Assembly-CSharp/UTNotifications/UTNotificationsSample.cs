using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UTNotifications
{
	public class UTNotificationsSample : MonoBehaviour
	{
		public ValidatedInputField DemoServerURLInputField;

		public Text NotifyAllText;

		public Text InitializeText;

		public Toggle NotificationsEnabledToggle;

		public CreateNotificationDialog CreateNotificationDialog;

		public NotificationDetailsDialog NotificationDetailsDialog;

		private static UTNotificationsSample instance;

		private static readonly string CleartextHint;

		private string notifyAllTextOriginal;

		private string initializeTextOriginal;

		public static UTNotificationsSample Instance
		{
			get
			{
				return null;
			}
		}

		public void Initialize()
		{
		}

		public void NotifyAll()
		{
		}

		[DebuggerHidden]
		public IEnumerator NotifyAll(string title, string text, int id, string notificationProfile, int badgeNumber)
		{
			return null;
		}

		public void CreateLocalNotification()
		{
		}

		public void ScheduleLocalNotification()
		{
		}

		public void ScheduleRepeatingLocalNotification()
		{
		}

		public void Hide(int id)
		{
		}

		public void Cancel(int id)
		{
		}

		public void CancelAll()
		{
		}

		public void IncrementBadge()
		{
		}

		public void OnNotificationsEnabledToggleValueChanged(bool value)
		{
		}

		protected Dictionary<string, string> UserData(bool hasImage)
		{
			return null;
		}

		protected List<Button> Buttons(bool hasButtons)
		{
			return null;
		}

		protected void OnInitialized()
		{
		}

		protected void SendRegistrationId(string providerName, string registrationId)
		{
		}

		protected void OnPushRegistrationFailed(string error)
		{
		}

		[DebuggerHidden]
		protected IEnumerator SendRegistrationId(string userId, string providerName, string registrationId)
		{
			return null;
		}

		[DebuggerHidden]
		private static IEnumerator HttpRequest(string uri, WWWForm wwwForm, UnityAction<string> onSuccess, UnityAction<string, string> onError)
		{
			return null;
		}

		private string EscapeURL(string stringToUrlEscape)
		{
			return null;
		}

		private static bool CheckAndroidCleartextAllowed(string hostname)
		{
			return false;
		}

		protected void OnNotificationClicked(ReceivedNotification notification)
		{
		}

		protected void OnNotificationsReceived(IList<ReceivedNotification> receivedNotifications)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
