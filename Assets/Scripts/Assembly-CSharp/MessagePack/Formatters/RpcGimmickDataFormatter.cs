namespace MessagePack.Formatters
{
	public sealed class RpcGimmickDataFormatter : IMessagePackFormatter<RpcGimmickData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcGimmickData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcGimmickData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
