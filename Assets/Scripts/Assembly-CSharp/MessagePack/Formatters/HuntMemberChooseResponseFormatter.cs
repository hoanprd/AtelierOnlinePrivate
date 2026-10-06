namespace MessagePack.Formatters
{
	public sealed class HuntMemberChooseResponseFormatter : IMessagePackFormatter<HuntMemberChooseResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntMemberChooseResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntMemberChooseResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
