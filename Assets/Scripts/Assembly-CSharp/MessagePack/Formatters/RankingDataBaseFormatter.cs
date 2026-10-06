namespace MessagePack.Formatters
{
	public sealed class RankingDataBaseFormatter : IMessagePackFormatter<RankingDataBase>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RankingDataBase value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RankingDataBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
