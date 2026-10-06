namespace MessagePack.Formatters
{
	public sealed class PurchaseBenefitFormatter : IMessagePackFormatter<PurchaseBenefit>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PurchaseBenefit value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PurchaseBenefit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
