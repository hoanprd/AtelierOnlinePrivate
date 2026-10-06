namespace MessagePack.Formatters
{
	public sealed class APIBattleEscape_RequestFormatter : IMessagePackFormatter<APIBattleEscape.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleEscape.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleEscape.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
