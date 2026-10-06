namespace MessagePack.Formatters
{
	public sealed class APIBattleFinish_Request_ScoreFormatter : IMessagePackFormatter<APIBattleFinish.Request.Score>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleFinish.Request.Score value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleFinish.Request.Score Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
