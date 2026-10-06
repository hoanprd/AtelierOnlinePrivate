using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	public class CreateNotificationDialog : MonoBehaviour
	{
		public delegate void OnComplete(string title, string text, int id, string notificationProfile, int badge, bool hasImage, bool hasButtons);

		public Text DialogTitle;

		public Text Title;

		public Text Text;

		public Text ID;

		public Text NotificationProfile;

		public Text Badge;

		public Toggle HasImage;

		public Toggle HasButtons;

		private OnComplete onComplete;

		public void Show(string dialogTitle, bool showHasImage, bool showHasButtons, OnComplete onComplete)
		{
		}

		public void OK()
		{
		}

		public void Cancel()
		{
		}

		private void Start()
		{
		}
	}
}
