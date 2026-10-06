namespace MessagePack.Formatters
{
	public sealed class ShopGachaLot_BeneInfoFormatter : IMessagePackFormatter<ShopGachaLot.BeneInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaLot.BeneInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaLot.BeneInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
