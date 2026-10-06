namespace MessagePack.Formatters
{
	public sealed class DungeonInfoResponseFormatter : IMessagePackFormatter<DungeonInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DungeonInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
