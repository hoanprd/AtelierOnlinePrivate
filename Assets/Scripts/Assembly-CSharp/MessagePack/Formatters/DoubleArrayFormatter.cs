namespace MessagePack.Formatters
{
	public sealed class DoubleArrayFormatter : IMessagePackFormatter<double[]>, IMessagePackFormatter
	{
		public static readonly DoubleArrayFormatter Instance;

		private DoubleArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, double[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public double[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
