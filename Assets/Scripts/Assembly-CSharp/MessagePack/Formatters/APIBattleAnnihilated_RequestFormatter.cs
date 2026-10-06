namespace MessagePack.Formatters
{
	public sealed class APIBattleAnnihilated_RequestFormatter : IMessagePackFormatter<APIBattleAnnihilated.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleAnnihilated.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleAnnihilated.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
