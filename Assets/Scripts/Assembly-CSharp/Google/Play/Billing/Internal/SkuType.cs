namespace Google.Play.Billing.Internal
{
	public sealed class SkuType
	{
		private readonly string _description;

		public static readonly SkuType Unknown;

		public static readonly SkuType InApp;

		public static readonly SkuType Subs;

		private SkuType(string description)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
