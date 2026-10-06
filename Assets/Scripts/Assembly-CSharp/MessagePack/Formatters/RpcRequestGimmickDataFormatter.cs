namespace MessagePack.Formatters
{
	public sealed class RpcRequestGimmickDataFormatter : IMessagePackFormatter<RpcRequestGimmickData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcRequestGimmickData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcRequestGimmickData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
