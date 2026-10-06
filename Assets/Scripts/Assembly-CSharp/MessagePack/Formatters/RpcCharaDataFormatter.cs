namespace MessagePack.Formatters
{
	public sealed class RpcCharaDataFormatter : IMessagePackFormatter<RpcCharaData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcCharaData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcCharaData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
