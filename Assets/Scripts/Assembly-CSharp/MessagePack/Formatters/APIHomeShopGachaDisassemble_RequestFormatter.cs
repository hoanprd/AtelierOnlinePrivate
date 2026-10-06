namespace MessagePack.Formatters
{
	public sealed class APIHomeShopGachaDisassemble_RequestFormatter : IMessagePackFormatter<APIHomeShopGachaDisassemble.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeShopGachaDisassemble.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeShopGachaDisassemble.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
