namespace MessagePack.Formatters
{
	public sealed class ShopGachaDisassembleResponseFormatter : IMessagePackFormatter<ShopGachaDisassembleResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopGachaDisassembleResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopGachaDisassembleResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
