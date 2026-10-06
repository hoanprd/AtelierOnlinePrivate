using System;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	public class SkuDetailsResponseListener : AndroidJavaProxy
	{
		private readonly SkuType _skuType;

		private Action<SkuType, AndroidJavaObject, AndroidJavaObject> OnSkuDetailsResponse__BackingField;

		public event Action<SkuType, AndroidJavaObject, AndroidJavaObject> OnSkuDetailsResponse
		{
			add
			{
			}
			remove
			{
			}
		}

		public SkuDetailsResponseListener(SkuType skuType)
			: base((string)null)
		{
		}

		private void onSkuDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
		}
	}
}
