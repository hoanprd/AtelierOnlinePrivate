namespace MessagePack.Formatters
{
	public sealed class AIItemInfoFormatter : IMessagePackFormatter<AIItemInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, AIItemInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public AIItemInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
