namespace MessagePack.Formatters
{
	public sealed class APIBattleStart_RequestFormatter : IMessagePackFormatter<APIBattleStart.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleStart.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleStart.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
