using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;

namespace Google.Play.Billing
{
	public interface IGooglePlayStoreExtensions : IStoreExtension
	{
		void SetObfuscatedAccountId(string obfuscatedAccountId);

		void SetObfuscatedProfileId(string obfuscatedProfileId);

		Dictionary<string, string> GetProductJSONDictionary();

		[Obsolete]
		void UpgradeDowngradeSubscription(string oldSkuMetadata, string newSku);

		void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode = GooglePlayStoreProrationMode.Unknown);

		void RestoreTransactions(Action<bool> callback);

		void FinishAdditionalTransaction(string productId, string transactionId);

		void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback);

		void SetDeferredPurchaseListener(Action<Product> callback);

		void EndConnection();
	}
}
