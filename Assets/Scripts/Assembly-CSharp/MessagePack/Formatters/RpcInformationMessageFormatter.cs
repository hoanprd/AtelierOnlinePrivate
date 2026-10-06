namespace MessagePack.Formatters
{
	public sealed class RpcInformationMessageFormatter : IMessagePackFormatter<RpcInformationMessage>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcInformationMessage value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcInformationMessage Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
