namespace MessagePack.Formatters
{
	public sealed class ShopGachaLotResponseFormatter : IMessagePackFormatter<ShopGachaLotResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaLotResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaLotResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
