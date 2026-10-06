namespace MessagePack.Formatters
{
	public sealed class ShopComDetail_ItemFormatter : IMessagePackFormatter<ShopComDetail.Item>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComDetail.Item value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComDetail.Item Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
