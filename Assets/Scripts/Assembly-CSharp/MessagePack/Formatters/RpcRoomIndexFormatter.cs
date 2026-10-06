namespace MessagePack.Formatters
{
	public sealed class RpcRoomIndexFormatter : IMessagePackFormatter<RpcRoomIndex>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcRoomIndex value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcRoomIndex Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
