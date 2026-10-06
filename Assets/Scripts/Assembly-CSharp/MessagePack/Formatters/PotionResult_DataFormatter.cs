namespace MessagePack.Formatters
{
	public sealed class PotionResult_DataFormatter : IMessagePackFormatter<PotionResult.Data>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, PotionResult.Data value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public PotionResult.Data Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
