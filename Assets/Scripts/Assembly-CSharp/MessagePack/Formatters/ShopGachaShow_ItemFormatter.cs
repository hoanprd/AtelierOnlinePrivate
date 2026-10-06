namespace MessagePack.Formatters
{
	public sealed class ShopGachaShow_ItemFormatter : IMessagePackFormatter<ShopGachaShow.Item>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaShow.Item value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaShow.Item Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
