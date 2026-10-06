namespace MessagePack.Formatters
{
	public sealed class PartyItemInvInfoFormatter : IMessagePackFormatter<PartyItemInvInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PartyItemInvInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PartyItemInvInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
