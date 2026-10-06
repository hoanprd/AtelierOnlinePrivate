namespace MessagePack.Formatters
{
	public sealed class TitleServerInfo_UrlInfoFormatter : IMessagePackFormatter<TitleServerInfo.UrlInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TitleServerInfo.UrlInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TitleServerInfo.UrlInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
