namespace MessagePack.Formatters
{
	public sealed class RpcPerfectDungeonDataFormatter : IMessagePackFormatter<RpcPerfectDungeonData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcPerfectDungeonData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcPerfectDungeonData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
