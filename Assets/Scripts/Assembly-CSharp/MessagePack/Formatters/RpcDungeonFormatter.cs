namespace MessagePack.Formatters
{
	public sealed class RpcDungeonFormatter : IMessagePackFormatter<RpcDungeon>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RpcDungeon value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RpcDungeon Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
