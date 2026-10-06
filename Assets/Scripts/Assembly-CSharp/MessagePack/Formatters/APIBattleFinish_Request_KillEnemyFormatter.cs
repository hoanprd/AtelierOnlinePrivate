namespace MessagePack.Formatters
{
	public sealed class APIBattleFinish_Request_KillEnemyFormatter : IMessagePackFormatter<APIBattleFinish.Request.KillEnemy>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleFinish.Request.KillEnemy value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleFinish.Request.KillEnemy Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
