namespace MessagePack.Formatters
{
	public sealed class ShopGachaShow_CoordinateFormatter : IMessagePackFormatter<ShopGachaShow.Coordinate>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaShow.Coordinate value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaShow.Coordinate Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
