namespace MessagePack.Formatters
{
	public sealed class NullableDoubleFormatter : IMessagePackFormatter<double?>, IMessagePackFormatter
	{
		public static readonly NullableDoubleFormatter Instance;

		private NullableDoubleFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, double? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public double? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
