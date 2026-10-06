using Google.Play.Billing.Internal;
using UnityEngine.Purchasing.Extension;

namespace Google.Play.Billing
{
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
