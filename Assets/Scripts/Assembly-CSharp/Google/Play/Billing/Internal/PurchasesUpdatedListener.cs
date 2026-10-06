using System;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	public class PurchasesUpdatedListener : AndroidJavaProxy
	{
		private Action<AndroidJavaObject, AndroidJavaObject> OnPurchasesUpdated__BackingField;

		public event Action<AndroidJavaObject, AndroidJavaObject> OnPurchasesUpdated
		{
			add
			{
			}
			remove
			{
			}
		}

		public PurchasesUpdatedListener()
			: base((string)null)
		{
		}

		private void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject purchasesList)
		{
		}
	}
}
