namespace MessagePack.Formatters
{
	public sealed class RankingMngInfoFormatter : IMessagePackFormatter<RankingMngInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingMngInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingMngInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
