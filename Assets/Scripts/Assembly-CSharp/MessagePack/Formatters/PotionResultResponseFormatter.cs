namespace MessagePack.Formatters
{
	public sealed class PotionResultResponseFormatter : IMessagePackFormatter<PotionResultResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PotionResultResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PotionResultResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
