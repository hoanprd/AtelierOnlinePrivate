namespace MessagePack.Formatters
{
	public sealed class SalonChooseResponseFormatter : IMessagePackFormatter<SalonChooseResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SalonChooseResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SalonChooseResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
