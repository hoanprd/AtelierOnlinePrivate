namespace MessagePack.Formatters
{
	public sealed class APIBattleFinish_RequestFormatter : IMessagePackFormatter<APIBattleFinish.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleFinish.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleFinish.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
