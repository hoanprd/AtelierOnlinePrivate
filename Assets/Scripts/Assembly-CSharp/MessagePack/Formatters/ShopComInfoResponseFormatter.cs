namespace MessagePack.Formatters
{
	public sealed class ShopComInfoResponseFormatter : IMessagePackFormatter<ShopComInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
