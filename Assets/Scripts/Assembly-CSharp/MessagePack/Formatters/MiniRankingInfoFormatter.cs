namespace MessagePack.Formatters
{
	public sealed class MiniRankingInfoFormatter : IMessagePackFormatter<MiniRankingInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, MiniRankingInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public MiniRankingInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
