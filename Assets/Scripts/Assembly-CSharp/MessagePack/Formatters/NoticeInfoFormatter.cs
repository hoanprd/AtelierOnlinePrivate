namespace MessagePack.Formatters
{
	public sealed class NoticeInfoFormatter : IMessagePackFormatter<NoticeInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, NoticeInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public NoticeInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
