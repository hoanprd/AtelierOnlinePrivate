using System;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	public class BillingClientStateListener : AndroidJavaProxy
	{
		private Action OnBillingServiceDisconnected__BackingField;

		private Action<AndroidJavaObject> OnBillingSetupFinished__BackingField;

		public event Action OnBillingServiceDisconnected
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<AndroidJavaObject> OnBillingSetupFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public BillingClientStateListener()
			: base((string)null)
		{
		}

		private void onBillingServiceDisconnected()
		{
		}

		private void onBillingSetupFinished(AndroidJavaObject billingResult)
		{
		}
	}
}
