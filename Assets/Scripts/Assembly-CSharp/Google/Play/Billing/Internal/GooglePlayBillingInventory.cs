using System.Collections.Generic;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Google.Play.Billing.Internal
{
	public class GooglePlayBillingInventory
	{
		private static readonly decimal Micros;

		private readonly object _inventoryLock;

		private readonly Dictionary<string, ProductDefinition> _catalog;

		private readonly Dictionary<string, string> _googlePlaySkuIdToUnityProductId;

		private readonly Dictionary<string, SkuDetails> _skuDetailsInventory;

		private readonly Dictionary<string, Purchase> _purchaseInventory;

		private readonly Dictionary<string, Purchase> _pendingPurchaseInventory;

		public void UpdateCatalog(IEnumerable<ProductDefinition> products)
		{
		}

		public void UpdateSkuDetailsInventory(IEnumerable<SkuDetails> skuDetailsList)
		{
		}

		public void UpdatePurchaseInventory(IEnumerable<Purchase> purchaseList)
		{
		}

		public bool GetUnityProductDefinition(string unityProductId, out ProductDefinition unityProduct)
		{
			unityProduct = null;
			return false;
		}

		public bool GetUnityProductId(string googlePlaySkuId, out string unityProductId)
		{
			unityProductId = null;
			return false;
		}

		public bool GetSkuDetails(string sku, out SkuDetails skuDetails)
		{
			skuDetails = null;
			return false;
		}

		public Dictionary<string, string> GetAllSkuDetails()
		{
			return null;
		}

		public bool GetPurchase(ProductDefinition product, out Purchase purchase)
		{
			purchase = null;
			return false;
		}

		public bool GetPurchase(string googlePlaySkuId, out Purchase purchase)
		{
			purchase = null;
			return false;
		}

		public bool RemovePurchase(string skuId)
		{
			return false;
		}

		public List<ProductDescription> CreateProductDescriptionList()
		{
			return null;
		}

		public List<ProductDescription> UpdateProductDescriptionList(IEnumerable<string> googlePlaySkuIds)
		{
			return null;
		}

		private ProductDescription GetProductDescriptionForSku(string skuId)
		{
			return null;
		}
	}
}
