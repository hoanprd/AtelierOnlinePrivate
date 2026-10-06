namespace MessagePack.Formatters
{
	public sealed class ShopComInfo_LimitInfoFormatter : IMessagePackFormatter<ShopComInfo.LimitInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComInfo.LimitInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComInfo.LimitInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
