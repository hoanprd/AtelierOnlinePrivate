namespace MessagePack.Formatters
{
	public sealed class ShopComSummaryResponseFormatter : IMessagePackFormatter<ShopComSummaryResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComSummaryResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComSummaryResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
