using Google.Play.Billing.Internal;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Google.Play.Billing
{
	public abstract class AbstractPurchasingModule
	{
		public abstract void Configure();

		protected void RegisterStore(string name, IStore store)
		{
		}

		protected void BindExtension<T>(T instance) where T : IStoreExtension
		{
		}

		protected void BindConfiguration<T>(T instance) where T : IStoreConfiguration
		{
		}
	}

	public class GooglePlayStoreModule : AbstractPurchasingModule
	{
		public const string StoreName = "GooglePlay";

		private IStore _storeInstance;

		private static GooglePlayStoreModule _moduleInstance;

		private static GooglePlayBillingUtil _util;

		public static AbstractPurchasingModule Instance()
		{
			return null;
		}

		public override void Configure()
		{
		}

		private IStore InstantiateGooglePlayBilling()
		{
			return null;
		}
	}
}
