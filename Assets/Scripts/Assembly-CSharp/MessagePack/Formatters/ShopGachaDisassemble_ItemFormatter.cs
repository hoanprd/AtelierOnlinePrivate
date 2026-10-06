namespace MessagePack.Formatters
{
	public sealed class ShopGachaDisassemble_ItemFormatter : IMessagePackFormatter<ShopGachaDisassemble.Item>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaDisassemble.Item value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaDisassemble.Item Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
