namespace MessagePack.Formatters
{
	public sealed class DegreeMissionInfoFormatter : IMessagePackFormatter<DegreeMissionInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DegreeMissionInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DegreeMissionInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
