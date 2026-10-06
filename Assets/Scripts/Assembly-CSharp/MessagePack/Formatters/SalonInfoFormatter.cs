namespace MessagePack.Formatters
{
	public sealed class SalonInfoFormatter : IMessagePackFormatter<SalonInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SalonInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SalonInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
