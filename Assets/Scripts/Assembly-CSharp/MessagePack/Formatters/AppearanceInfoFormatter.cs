namespace MessagePack.Formatters
{
	public sealed class AppearanceInfoFormatter : IMessagePackFormatter<AppearanceInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AppearanceInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AppearanceInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
