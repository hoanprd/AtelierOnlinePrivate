namespace MessagePack.Formatters
{
	public sealed class ShopGachaShowResponseFormatter : IMessagePackFormatter<ShopGachaShowResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaShowResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaShowResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
