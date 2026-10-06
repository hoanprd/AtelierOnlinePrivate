namespace MessagePack.Formatters
{
	public sealed class RpcCharaItemUseFormatter : IMessagePackFormatter<RpcCharaItemUse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcCharaItemUse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcCharaItemUse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
