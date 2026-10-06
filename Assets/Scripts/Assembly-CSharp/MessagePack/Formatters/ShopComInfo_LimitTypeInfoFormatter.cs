namespace MessagePack.Formatters
{
	public sealed class ShopComInfo_LimitTypeInfoFormatter : IMessagePackFormatter<ShopComInfo.LimitTypeInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComInfo.LimitTypeInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComInfo.LimitTypeInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
