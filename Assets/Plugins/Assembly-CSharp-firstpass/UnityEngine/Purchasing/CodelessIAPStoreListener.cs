using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class CodelessIAPStoreListener : IStoreListener
	{
		private static CodelessIAPStoreListener instance;

		private List<IAPButton> activeButtons;

		private List<IAPListener> activeListeners;

		private static bool unityPurchasingInitialized;

		protected IStoreController controller;

		protected IExtensionProvider extensions;

		//protected ProductCatalog catalog;

		public static bool initializationComplete;

		public static CodelessIAPStoreListener Instance
		{
			get
			{
				return null;
			}
		}

		public IStoreController StoreController
		{
			get
			{
				return null;
			}
		}

		public IExtensionProvider ExtensionProvider
		{
			get
			{
				return null;
			}
		}

		private CodelessIAPStoreListener()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeCodelessPurchasingOnLoad()
		{
		}

		private static void InitializePurchasing()
		{
		}

		private static void CreateCodelessIAPStoreListenerInstance()
		{
		}

		public bool HasProductInCatalog(string productID)
		{
			return false;
		}

		public Product GetProduct(string productID)
		{
			return null;
		}

		public void AddButton(IAPButton button)
		{
		}

		public void RemoveButton(IAPButton button)
		{
		}

		public void AddListener(IAPListener listener)
		{
		}

		public void RemoveListener(IAPListener listener)
		{
		}

		public void InitiatePurchase(string productID)
		{
		}

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

        public void OnInitializeFailed(InitializationFailureReason error, string message)
        {
        }

        public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			return PurchaseProcessingResult.Complete;
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
		{
		}
	}
}
