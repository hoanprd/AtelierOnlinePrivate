namespace MessagePack.Formatters
{
	public sealed class RpcRoomDataFormatter : IMessagePackFormatter<RpcRoomData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcRoomData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcRoomData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
