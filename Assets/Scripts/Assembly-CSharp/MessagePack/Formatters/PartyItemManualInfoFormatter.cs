namespace MessagePack.Formatters
{
	public sealed class PartyItemManualInfoFormatter : IMessagePackFormatter<PartyItemManualInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyItemManualInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyItemManualInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
