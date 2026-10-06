namespace MessagePack.Formatters
{
	public sealed class RpcExqRoomInfoFormatter : IMessagePackFormatter<RpcExqRoomInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcExqRoomInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcExqRoomInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
