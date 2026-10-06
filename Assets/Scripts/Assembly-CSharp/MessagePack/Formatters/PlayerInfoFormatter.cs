namespace MessagePack.Formatters
{
	public sealed class PlayerInfoFormatter : IMessagePackFormatter<PlayerInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PlayerInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PlayerInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
