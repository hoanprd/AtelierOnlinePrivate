namespace MessagePack.Formatters
{
	public sealed class ShopGachaShowFormatter : IMessagePackFormatter<ShopGachaShow>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaShow value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaShow Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
