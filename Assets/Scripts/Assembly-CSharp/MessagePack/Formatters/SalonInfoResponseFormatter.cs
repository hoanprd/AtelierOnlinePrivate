namespace MessagePack.Formatters
{
	public sealed class SalonInfoResponseFormatter : IMessagePackFormatter<SalonInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SalonInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SalonInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
