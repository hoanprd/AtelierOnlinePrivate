using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;

namespace Google.Play.Billing
{
	public class FakeGooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension
	{
		public void UpgradeDowngradeSubscription(string oldSku, string newSku)
		{
		}

		public void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode = GooglePlayStoreProrationMode.Unknown)
		{
		}

		public void RestoreTransactions(Action<bool> callback)
		{
		}

		public void SetObfuscatedAccountId(string obfuscatedAccountId)
		{
		}

		public void SetObfuscatedProfileId(string obfuscatedProfileId)
		{
		}

		public Dictionary<string, string> GetProductJSONDictionary()
		{
			return null;
		}

		public void FinishAdditionalTransaction(string productId, string transactionId)
		{
		}

		public void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback)
		{
		}

		public void SetDeferredPurchaseListener(Action<Product> callback)
		{
		}

		public void EndConnection()
		{
		}
	}
}
