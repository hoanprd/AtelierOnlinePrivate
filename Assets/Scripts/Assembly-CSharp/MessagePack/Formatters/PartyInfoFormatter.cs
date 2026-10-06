namespace MessagePack.Formatters
{
	public sealed class PartyInfoFormatter : IMessagePackFormatter<PartyInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
