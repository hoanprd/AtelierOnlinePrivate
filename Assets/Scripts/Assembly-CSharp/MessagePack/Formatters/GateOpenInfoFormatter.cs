namespace MessagePack.Formatters
{
	public sealed class GateOpenInfoFormatter : IMessagePackFormatter<GateOpenInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GateOpenInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GateOpenInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
