namespace MessagePack.Formatters
{
	public sealed class DecimalFormatter : IMessagePackFormatter<decimal>, IMessagePackFormatter
	{
		public static readonly DecimalFormatter Instance;

		private DecimalFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, decimal value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public decimal Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0m;
		}
	}
}
