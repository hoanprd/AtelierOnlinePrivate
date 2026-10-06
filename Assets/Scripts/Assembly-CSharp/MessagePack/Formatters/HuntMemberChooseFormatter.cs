namespace MessagePack.Formatters
{
	public sealed class HuntMemberChooseFormatter : IMessagePackFormatter<HuntMemberChoose>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntMemberChoose value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntMemberChoose Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
