namespace MessagePack.Formatters
{
	public sealed class ShopInfoResponseFormatter : IMessagePackFormatter<ShopInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
