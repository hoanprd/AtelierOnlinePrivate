namespace MessagePack.Formatters
{
	public sealed class APIBattleAnnihilated_Request_UseItemFormatter : IMessagePackFormatter<APIBattleAnnihilated.Request.UseItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleAnnihilated.Request.UseItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleAnnihilated.Request.UseItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
