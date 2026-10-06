namespace MessagePack.Formatters
{
	public sealed class HuntResultInfoFormatter : IMessagePackFormatter<HuntResultInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntResultInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntResultInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
