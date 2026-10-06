namespace MessagePack.Formatters
{
	public sealed class CostInfoFormatter : IMessagePackFormatter<CostInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, CostInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public CostInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
