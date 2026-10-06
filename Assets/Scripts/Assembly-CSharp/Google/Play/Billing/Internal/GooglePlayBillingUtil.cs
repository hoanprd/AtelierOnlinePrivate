using System;
using System.Collections.Generic;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	public class GooglePlayBillingUtil : MonoBehaviour
	{
		private const string GooglePlayBillingLoggingTag = "Google Play Store: ";

		private readonly ILogger _logger;

		private static readonly List<Action> _callbacks;

		private static bool _callbacksPending;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void RunOnMainThread(Action runnable)
		{
		}

		public void LogFormat(string format, params object[] args)
		{
		}

		public void LogWarningFormat(string format, params object[] args)
		{
		}

		public void LogErrorFormat(string format, params object[] args)
		{
		}
	}
}
