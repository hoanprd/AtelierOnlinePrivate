namespace MessagePack.Formatters
{
	public sealed class RpcZoneChangeFormatter : IMessagePackFormatter<RpcZoneChange>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcZoneChange value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcZoneChange Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
