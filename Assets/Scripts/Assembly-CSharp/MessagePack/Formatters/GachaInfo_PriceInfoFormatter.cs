namespace MessagePack.Formatters
{
	public sealed class GachaInfo_PriceInfoFormatter : IMessagePackFormatter<GachaInfo.PriceInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GachaInfo.PriceInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GachaInfo.PriceInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
