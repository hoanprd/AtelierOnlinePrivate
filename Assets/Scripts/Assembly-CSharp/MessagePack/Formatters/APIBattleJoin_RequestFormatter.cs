namespace MessagePack.Formatters
{
	public sealed class APIBattleJoin_RequestFormatter : IMessagePackFormatter<APIBattleJoin.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleJoin.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleJoin.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
