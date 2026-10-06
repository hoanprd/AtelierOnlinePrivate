using System;

namespace Google.Play.Billing.Internal
{
	internal static class Constants
	{
		public const string Version = "3.0.0-unity";

		public static readonly TimeSpan BillingClientAsyncTimeout;

		public const string BuildMethod = "build";

		public const string BillingClient = "com.android.billingclient.api.BillingClientImpl";

		public const string BillingClientSetUpMethod = "initialize";

		public const string BillingClientStartConnectionMethod = "startConnection";

		public const string BillingClientLaunchBillingFlowMethod = "launchBillingFlow";

		public const string BillingClientConsumePurchaseMethod = "consumeAsync";

		public const string BillingClientAcknowledgePurchaseMethod = "acknowledgePurchase";

		public const string BillingClientEndConnectionMethod = "endConnection";

		public const string AcknowledgeResponseListener = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";

		public const string BillingClientStateListener = "com.android.billingclient.api.BillingClientStateListener";

		public const string ConsumeResponseListener = "com.android.billingclient.api.ConsumeResponseListener";

		public const string PurchaseUpdatedListener = "com.android.billingclient.api.PurchasesUpdatedListener";

		public const string AcknowledgeParamsBuilder = "com.android.billingclient.api.AcknowledgePurchaseParams$Builder";

		public const string AcknowledgeParamsBuilderSetPurchaseTokenMethod = "setPurchaseToken";

		public const string ConsumeParamsBuilder = "com.android.billingclient.api.ConsumeParams$Builder";

		public const string ConsumeParamsBuilderSetPurchaseTokenMethod = "setPurchaseToken";

		public const string BillingFlowParamsBuilder = "com.android.billingclient.api.BillingFlowParams$Builder";

		public const string BillingFlowParamsBuilderSetSkuDetailsMethod = "setSkuDetails";

		public const string BillingFlowParamsBuilderSetObfuscatedAccountIdMethod = "setObfuscatedAccountId";

		public const string BillingFlowParamsBuilderSetObfuscatedProfileIdMethod = "setObfuscatedProfileId";

		public const string BillingFlowParamsBuilderSetOldSkuMethod = "setOldSku";

		public const string BillingFlowParamsBuilderSetReplaceSkusProrationModeMethod = "setReplaceSkusProrationMode";

		public const string PurchaseGetOriginalJsonMethod = "getOriginalJson";

		public const string PurchaseGetSignatureMethod = "getSignature";

		public const string QueryPurchasesMethod = "queryPurchases";

		public const string PurchasesResultGetBillingResultMethod = "getBillingResult";

		public const string PurchasesResultGetPurchasesListMethod = "getPurchasesList";

		public const string SkuDetailsClass = "com.android.billingclient.api.SkuDetails";

		public const string SkuDetailsGetOriginalJson = "getOriginalJson";

		public const string SkuDetailsParamBuilder = "com.android.billingclient.api.SkuDetailsParams$Builder";

		public const string SkuDetailsParamBuilderSetSkuListMethod = "setSkusList";

		public const string SkuDetailsParamBuilderSetTypeMethod = "setType";

		public const string QuerySkuDetailsMethod = "querySkuDetailsAsync";

		public const string SkuDetailsResponseListener = "com.android.billingclient.api.SkuDetailsResponseListener";

		public const string PriceChangeFlowParamsBuilder = "com.android.billingclient.api.PriceChangeFlowParams$Builder";

		public const string PriceChangeFlowParamsBuilderSetSkuDetailsMethod = "setSkuDetails";

		public const string LaunchPriceChangeConfirmationFlowMethod = "launchPriceChangeConfirmationFlow";

		public const string PriceChangeConfirmationListener = "com.android.billingclient.api.PriceChangeConfirmationListener";
	}
}
