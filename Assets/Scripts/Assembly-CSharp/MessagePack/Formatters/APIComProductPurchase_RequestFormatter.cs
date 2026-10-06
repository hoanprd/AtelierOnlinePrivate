namespace MessagePack.Formatters
{
	public sealed class APIComProductPurchase_RequestFormatter : IMessagePackFormatter<APIComProductPurchase.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComProductPurchase.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComProductPurchase.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
