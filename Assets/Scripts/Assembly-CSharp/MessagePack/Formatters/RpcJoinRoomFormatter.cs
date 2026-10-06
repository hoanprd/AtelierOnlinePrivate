namespace MessagePack.Formatters
{
	public sealed class RpcJoinRoomFormatter : IMessagePackFormatter<RpcJoinRoom>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcJoinRoom value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcJoinRoom Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
