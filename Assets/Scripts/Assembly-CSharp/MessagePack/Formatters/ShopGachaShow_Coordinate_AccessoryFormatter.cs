namespace MessagePack.Formatters
{
	public sealed class ShopGachaShow_Coordinate_AccessoryFormatter : IMessagePackFormatter<ShopGachaShow.Coordinate.Accessory>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaShow.Coordinate.Accessory value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaShow.Coordinate.Accessory Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
