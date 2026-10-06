namespace MessagePack.Formatters
{
	public sealed class RpcPerfectGimmickDataFormatter : IMessagePackFormatter<RpcPerfectGimmickData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcPerfectGimmickData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcPerfectGimmickData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
