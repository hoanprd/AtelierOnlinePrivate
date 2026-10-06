namespace MessagePack.Formatters
{
	public sealed class DoubleFormatter : IMessagePackFormatter<double>, IMessagePackFormatter
	{
		public static readonly DoubleFormatter Instance;

		private DoubleFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, double value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public double Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
