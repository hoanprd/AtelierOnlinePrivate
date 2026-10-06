namespace MessagePack.Formatters
{
	public sealed class ShopGachaLot_LotGetItemFormatter : IMessagePackFormatter<ShopGachaLot.LotGetItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaLot.LotGetItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaLot.LotGetItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
