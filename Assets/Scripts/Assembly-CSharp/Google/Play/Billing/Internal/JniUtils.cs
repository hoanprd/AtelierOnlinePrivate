using System.Collections.Generic;
using UnityEngine;

namespace Google.Play.Billing.Internal
{
	public class JniUtils
	{
		private GooglePlayBillingUtil _util;

		public JniUtils(GooglePlayBillingUtil util)
		{
		}

		public static AndroidJavaObject GetUnityAndroidActivity()
		{
			return null;
		}

		public static AndroidJavaObject GetApplicationContext()
		{
			return null;
		}

		public BillingResponseCode GetResponseCodeFromBillingResult(AndroidJavaObject billingResult)
		{
			return BillingResponseCode.Ok;
		}

		public static string GetDebugMessageFromBillingResult(AndroidJavaObject billingResult)
		{
			return null;
		}

		public BillingResponseCode GetResponseCodeFromQueryPurchasesResult(AndroidJavaObject javaPurchasesResult)
		{
			return BillingResponseCode.Ok;
		}

		public static AndroidJavaObject CreateJavaArrayList(params string[] inputs)
		{
			return null;
		}

		public IEnumerable<SkuDetails> ParseSkuDetailsResult(AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
			return null;
		}

		public IEnumerable<Purchase> ParseQueryPurchasesResult(AndroidJavaObject javaPurchasesResult)
		{
			return null;
		}

		public IEnumerable<Purchase> ParseJavaPurchaseList(AndroidJavaObject javaPurchasesList)
		{
			return null;
		}
	}
}
