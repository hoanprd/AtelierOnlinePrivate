namespace MessagePack.Formatters
{
	public sealed class RpcLeaveRoomFormatter : IMessagePackFormatter<RpcLeaveRoom>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcLeaveRoom value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcLeaveRoom Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
