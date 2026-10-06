namespace MessagePack.Formatters
{
	public sealed class ShopGachaDisassembleFormatter : IMessagePackFormatter<ShopGachaDisassemble>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaDisassemble value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaDisassemble Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
