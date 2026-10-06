namespace MessagePack.Formatters
{
	public sealed class ShopGachaShow_PickupInfoFormatter : IMessagePackFormatter<ShopGachaShow.PickupInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaShow.PickupInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaShow.PickupInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
