namespace MessagePack.Formatters
{
	public sealed class APIBattleRevive_RequestFormatter : IMessagePackFormatter<APIBattleRevive.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleRevive.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleRevive.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
