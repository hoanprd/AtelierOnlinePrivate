using System;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	public class PriceChangeConfirmationListener : AndroidJavaProxy
	{
		private Action<AndroidJavaObject> OnPriceChangeConfirmationResult__BackingField;

		public event Action<AndroidJavaObject> OnPriceChangeConfirmationResult
		{
			add
			{
			}
			remove
			{
			}
		}

		public PriceChangeConfirmationListener()
			: base((string)null)
		{
		}

		private void onPriceChangeConfirmationResult(AndroidJavaObject billingResult)
		{
		}
	}
}
