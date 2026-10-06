namespace MessagePack.Formatters
{
	public sealed class NullableUInt16Formatter : IMessagePackFormatter<ushort?>, IMessagePackFormatter
	{
		public static readonly NullableUInt16Formatter Instance;

		private NullableUInt16Formatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, ushort? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ushort? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
