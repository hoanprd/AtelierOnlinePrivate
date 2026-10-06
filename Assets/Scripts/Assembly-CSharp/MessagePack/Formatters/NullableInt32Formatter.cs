namespace MessagePack.Formatters
{
	public sealed class NullableInt32Formatter : IMessagePackFormatter<int?>, IMessagePackFormatter
	{
		public static readonly NullableInt32Formatter Instance;

		private NullableInt32Formatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, int? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public int? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
