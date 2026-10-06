namespace MessagePack.Formatters
{
	public sealed class PartyItemResponseFormatter : IMessagePackFormatter<PartyItemResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyItemResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyItemResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
