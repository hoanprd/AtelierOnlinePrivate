namespace MessagePack.Formatters
{
	public sealed class DfCntInfoFormatter : IMessagePackFormatter<DfCntInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DfCntInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DfCntInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
