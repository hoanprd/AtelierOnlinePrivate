namespace MessagePack.Formatters
{
	public sealed class APIHomeShopGachaDisassemble_Request_LotInfoFormatter : IMessagePackFormatter<APIHomeShopGachaDisassemble.Request.LotInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeShopGachaDisassemble.Request.LotInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeShopGachaDisassemble.Request.LotInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
