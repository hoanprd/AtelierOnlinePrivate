namespace MessagePack.Formatters
{
	public sealed class ExceedPrice_LevelLimitFormatter : IMessagePackFormatter<ExceedPrice.LevelLimit>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExceedPrice.LevelLimit value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExceedPrice.LevelLimit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
