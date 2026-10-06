namespace MessagePack.Formatters
{
	public sealed class BuyResponseFormatter : IMessagePackFormatter<BuyResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BuyResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BuyResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
