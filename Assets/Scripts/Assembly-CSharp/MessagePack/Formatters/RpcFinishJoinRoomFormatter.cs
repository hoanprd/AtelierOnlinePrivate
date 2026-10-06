namespace MessagePack.Formatters
{
	public sealed class RpcFinishJoinRoomFormatter : IMessagePackFormatter<RpcFinishJoinRoom>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcFinishJoinRoom value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcFinishJoinRoom Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
