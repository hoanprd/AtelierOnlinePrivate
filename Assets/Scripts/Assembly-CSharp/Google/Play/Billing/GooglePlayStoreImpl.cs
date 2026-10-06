using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Google.Play.Billing.Internal;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Google.Play.Billing
{
	public class GooglePlayStoreImpl : IStore, IGooglePlayStoreExtensions, IGooglePlayConfiguration, IStoreExtension, IStoreConfiguration
	{
		private enum AsyncRequestStatus
		{
			Pending = 0,
			Failed = 1,
			Succeed = 2
		}

		private AndroidJavaObject _billingClient;

		private BillingClientStateListener _billingClientStateListener;

		private Action<Product> _deferredPurchaseListener;

		private IStoreCallback _callback;

		private readonly GooglePlayBillingInventory _inventory;

		private readonly GooglePlayBillingUtil _billingUtil;

		private readonly JniUtils _jniUtils;

		private Dictionary<SkuType, AsyncRequestStatus> _billingClientQuerySkuDetailsCallStatus;

		private bool _billingClientReady;

		private ProductDefinition _productInPurchaseFlow;

		private string _obfuscatedProfileId;

		private string _obfuscatedAccountId;

		private bool _deferredPurchasesEnabled;

		public GooglePlayStoreImpl(GooglePlayBillingUtil googlePlayBillingUtil)
		{
		}

		public void Initialize(IStoreCallback callback)
		{
		}

		public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		private void RetrieveProductsInternal(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		public void Purchase(ProductDefinition product, string developerPayload)
		{
		}

		public void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		public void SetObfuscatedAccountId(string accountId)
		{
		}

		public void SetObfuscatedProfileId(string profileId)
		{
		}

		public void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback)
		{
		}

		public void EndConnection()
		{
		}

		public void UpgradeDowngradeSubscription(string oldSkuMetadata, string newSku)
		{
		}

		public void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode)
		{
		}

		public void RestoreTransactions(Action<bool> callback)
		{
		}

		public void FinishAdditionalTransaction(string productId, string transactionId)
		{
		}

		public Dictionary<string, string> GetProductJSONDictionary()
		{
			return null;
		}

		public void SetDeferredPurchaseListener(Action<Product> callback)
		{
		}

		public void EnableDeferredPurchase()
		{
		}

		private bool IsGooglePlayInAppBillingServiceAvailable()
		{
			return false;
		}

		private void InstantiateBillingClientAndMakeConnection()
		{
		}

		private void MarkBillingClientStartConnectionCallComplete(AndroidJavaObject billingResult)
		{
		}

		private void QuerySkuDetailsForSkuType(ReadOnlyCollection<ProductDefinition> products, SkuType skuType)
		{
		}

		private void ParseSkuDetailsResults(SkuType skuType, AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
		}

		private void NotifyUnityRetrieveProductsResults()
		{
		}

		private BillingResponseCode QueryPurchasesForSkuType(SkuType skuType)
		{
			return BillingResponseCode.Ok;
		}

		private void ParsePurchaseResult(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
		}

		private void ProcessAcknowledgePurchaseResult(string skuId, SkuType skuType, AndroidJavaObject billingResult)
		{
		}

		private void ProcessConsumePurchaseResult(string skuId, AndroidJavaObject billingResult)
		{
		}

		private void LaunchBillingFlow(AndroidJavaObject billingFlowParamBuilder)
		{
		}

		private void FinishTransactionInternal(Purchase purchase, ProductType productType)
		{
		}

		private void ProcessPriceChangeResult(AndroidJavaObject billingResult, Action<bool> callback)
		{
		}
	}
}
