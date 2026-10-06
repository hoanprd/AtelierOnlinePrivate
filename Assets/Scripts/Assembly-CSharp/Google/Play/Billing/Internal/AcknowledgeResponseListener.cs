using System;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	public class AcknowledgeResponseListener : AndroidJavaProxy
	{
		private readonly string _skuId;

		private readonly SkuType _skuType;

		private Action<string, SkuType, AndroidJavaObject> OnAcknowledgeResponse__BackingField;

		public event Action<string, SkuType, AndroidJavaObject> OnAcknowledgeResponse
		{
			add
			{
			}
			remove
			{
			}
		}

		public AcknowledgeResponseListener(string skuId, SkuType skuType)
			: base((string)null)
		{
		}

		private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
		}
	}
}
