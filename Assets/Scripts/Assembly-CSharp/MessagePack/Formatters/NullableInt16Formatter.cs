namespace MessagePack.Formatters
{
	public sealed class NullableInt16Formatter : IMessagePackFormatter<short?>, IMessagePackFormatter
	{
		public static readonly NullableInt16Formatter Instance;

		private NullableInt16Formatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, short? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public short? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
