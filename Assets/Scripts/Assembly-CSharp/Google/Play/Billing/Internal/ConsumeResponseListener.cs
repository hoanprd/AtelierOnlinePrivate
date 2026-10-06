using System;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	public class ConsumeResponseListener : AndroidJavaProxy
	{
		private readonly string _skuId;

		private Action<string, AndroidJavaObject> OnConsumeResponse__BackingField;

		public event Action<string, AndroidJavaObject> OnConsumeResponse
		{
			add
			{
			}
			remove
			{
			}
		}

		public ConsumeResponseListener(string skuId)
			: base((string)null)
		{
		}

		private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken)
		{
		}
	}
}
