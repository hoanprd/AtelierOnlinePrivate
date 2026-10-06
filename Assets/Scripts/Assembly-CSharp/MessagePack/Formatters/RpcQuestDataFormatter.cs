namespace MessagePack.Formatters
{
	public sealed class RpcQuestDataFormatter : IMessagePackFormatter<RpcQuestData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcQuestData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcQuestData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
