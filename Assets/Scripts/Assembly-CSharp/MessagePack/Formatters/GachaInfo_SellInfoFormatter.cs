namespace MessagePack.Formatters
{
	public sealed class GachaInfo_SellInfoFormatter : IMessagePackFormatter<GachaInfo.SellInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GachaInfo.SellInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GachaInfo.SellInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
