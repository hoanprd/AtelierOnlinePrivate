namespace MessagePack.Formatters
{
	public sealed class DegreeInfoFormatter : IMessagePackFormatter<DegreeInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DegreeInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DegreeInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
