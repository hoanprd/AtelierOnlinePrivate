using UnityEngine.Purchasing.Extension;

namespace Google.Play.Billing
{
	public interface IGooglePlayConfiguration : IStoreConfiguration
	{
		void EnableDeferredPurchase();
	}
}
