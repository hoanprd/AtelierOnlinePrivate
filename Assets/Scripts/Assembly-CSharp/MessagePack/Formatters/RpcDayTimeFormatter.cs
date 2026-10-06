namespace MessagePack.Formatters
{
	public sealed class RpcDayTimeFormatter : IMessagePackFormatter<RpcDayTime>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcDayTime value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcDayTime Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
