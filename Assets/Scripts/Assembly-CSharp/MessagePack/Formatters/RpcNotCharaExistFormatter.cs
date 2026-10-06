namespace MessagePack.Formatters
{
	public sealed class RpcNotCharaExistFormatter : IMessagePackFormatter<RpcNotCharaExist>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcNotCharaExist value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcNotCharaExist Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
