using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	public class ValidatedInputDependent : MonoBehaviour
	{
		public bool AllowWhenPushDisabled;

		public ValidatedInputField[] ValidatedInputFields;

		private UnityEngine.UI.Button button;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool PushNotificationsEnabled()
		{
			return false;
		}
	}
}
