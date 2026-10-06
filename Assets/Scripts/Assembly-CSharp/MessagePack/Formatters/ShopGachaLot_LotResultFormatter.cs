namespace MessagePack.Formatters
{
	public sealed class ShopGachaLot_LotResultFormatter : IMessagePackFormatter<ShopGachaLot.LotResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaLot.LotResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaLot.LotResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
