namespace MessagePack.Formatters
{
	public sealed class TitleServerInfoFormatter : IMessagePackFormatter<TitleServerInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TitleServerInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TitleServerInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
