namespace MessagePack.Formatters
{
	public sealed class ManualItemInfoFormatter : IMessagePackFormatter<ManualItemInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ManualItemInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ManualItemInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
