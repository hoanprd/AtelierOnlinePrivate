namespace MessagePack.Formatters
{
	public sealed class RpcCharaAnimationFormatter : IMessagePackFormatter<RpcCharaAnimation>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcCharaAnimation value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcCharaAnimation Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
