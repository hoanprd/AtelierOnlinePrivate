namespace MessagePack.Formatters
{
	public sealed class HuntRecommendResponseFormatter : IMessagePackFormatter<HuntRecommendResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntRecommendResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntRecommendResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
