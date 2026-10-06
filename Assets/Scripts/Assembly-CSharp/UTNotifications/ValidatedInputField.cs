using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	public class ValidatedInputField : MonoBehaviour
	{
		public string RequiredPattern;

		private Regex regex;

		private InputField inputField;

		private GameObject incorrect;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsValid()
		{
			return false;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnValueChanged(string value)
		{
		}
	}
}
