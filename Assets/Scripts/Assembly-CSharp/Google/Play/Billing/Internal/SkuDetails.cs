using System;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	[Serializable]
	public class SkuDetails
	{
		public string productId;

		public string type;

		public string title;

		public string description;

		public string skuDetailsToken;

		public string iconUrl;

		public string price;

		public long price_amount_micros;

		public string price_currency_code;

		public string original_price;

		public long original_price_amount_micros;

		public string subscriptionPeriod;

		public string freeTrialPeriod;

		public string introductoryPrice;

		public long introductoryPriceAmountMicros;

		public string introductoryPricePeriod;

		public int introductoryPriceCycles;

		public string JsonSkuDetails { get; private set; }

		public static bool FromJson(string jsonSkuDetails, out SkuDetails skuDetails)
		{
			skuDetails = null;
			return false;
		}

		public AndroidJavaObject ToJava()
		{
			return null;
		}
	}
}
