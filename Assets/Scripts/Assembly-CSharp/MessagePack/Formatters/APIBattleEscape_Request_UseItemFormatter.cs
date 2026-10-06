namespace MessagePack.Formatters
{
	public sealed class APIBattleEscape_Request_UseItemFormatter : IMessagePackFormatter<APIBattleEscape.Request.UseItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleEscape.Request.UseItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleEscape.Request.UseItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
