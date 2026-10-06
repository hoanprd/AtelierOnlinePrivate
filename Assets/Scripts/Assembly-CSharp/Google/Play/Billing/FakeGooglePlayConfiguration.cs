using UnityEngine.Purchasing.Extension;

namespace Google.Play.Billing
{
	public class FakeGooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration
	{
		public void EnableDeferredPurchase()
		{
		}
	}
}
