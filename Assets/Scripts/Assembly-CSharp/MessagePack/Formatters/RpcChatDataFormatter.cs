namespace MessagePack.Formatters
{
	public sealed class RpcChatDataFormatter : IMessagePackFormatter<RpcChatData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcChatData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcChatData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
