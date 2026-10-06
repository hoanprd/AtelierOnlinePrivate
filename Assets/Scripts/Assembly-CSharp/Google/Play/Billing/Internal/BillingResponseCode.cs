namespace Google.Play.Billing.Internal
{
	public enum BillingResponseCode
	{
		ServiceTimeout = -3,
		FeatureNotSupported = -2,
		ServiceDisconnected = -1,
		Ok = 0,
		UserCancelled = 1,
		ServiceUnavailable = 2,
		BillingUnavailable = 3,
		ItemUnavailable = 4,
		DeveloperError = 5,
		Error = 6,
		ItemAlreadyOwned = 7,
		ItemNotOwned = 8
	}
}
