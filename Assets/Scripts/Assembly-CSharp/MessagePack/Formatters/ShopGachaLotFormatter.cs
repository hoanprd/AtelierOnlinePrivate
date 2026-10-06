namespace MessagePack.Formatters
{
	public sealed class ShopGachaLotFormatter : IMessagePackFormatter<ShopGachaLot>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaLot value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaLot Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
