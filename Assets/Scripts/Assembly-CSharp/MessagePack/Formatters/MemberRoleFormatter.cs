namespace MessagePack.Formatters
{
	public sealed class MemberRoleFormatter : IMessagePackFormatter<MemberRole>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, MemberRole value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public MemberRole Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
