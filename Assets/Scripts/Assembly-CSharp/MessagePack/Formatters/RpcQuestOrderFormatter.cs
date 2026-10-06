namespace MessagePack.Formatters
{
	public sealed class RpcQuestOrderFormatter : IMessagePackFormatter<RpcQuestOrder>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcQuestOrder value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcQuestOrder Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
