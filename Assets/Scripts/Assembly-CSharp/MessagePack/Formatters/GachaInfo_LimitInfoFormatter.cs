namespace MessagePack.Formatters
{
	public sealed class GachaInfo_LimitInfoFormatter : IMessagePackFormatter<GachaInfo.LimitInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GachaInfo.LimitInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GachaInfo.LimitInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
