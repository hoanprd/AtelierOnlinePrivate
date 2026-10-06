namespace MessagePack.Formatters
{
	public sealed class PotionResultFormatter : IMessagePackFormatter<PotionResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PotionResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PotionResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
