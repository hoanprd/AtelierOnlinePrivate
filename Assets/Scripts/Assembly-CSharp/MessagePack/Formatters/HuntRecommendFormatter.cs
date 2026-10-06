namespace MessagePack.Formatters
{
	public sealed class HuntRecommendFormatter : IMessagePackFormatter<HuntRecommend>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntRecommend value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntRecommend Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
