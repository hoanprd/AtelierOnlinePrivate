namespace MessagePack.Formatters
{
	public sealed class RpcExqReturnRoomFormatter : IMessagePackFormatter<RpcExqReturnRoom>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcExqReturnRoom value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcExqReturnRoom Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
