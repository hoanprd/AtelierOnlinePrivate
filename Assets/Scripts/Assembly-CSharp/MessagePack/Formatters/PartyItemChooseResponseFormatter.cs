namespace MessagePack.Formatters
{
	public sealed class PartyItemChooseResponseFormatter : IMessagePackFormatter<PartyItemChooseResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyItemChooseResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyItemChooseResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
