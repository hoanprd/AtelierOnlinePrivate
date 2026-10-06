namespace MessagePack.Formatters
{
	public sealed class ShopComShowResponseFormatter : IMessagePackFormatter<ShopComShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
