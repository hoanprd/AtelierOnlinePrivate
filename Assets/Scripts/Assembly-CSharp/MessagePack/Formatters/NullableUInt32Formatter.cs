namespace MessagePack.Formatters
{
	public sealed class NullableUInt32Formatter : IMessagePackFormatter<uint?>, IMessagePackFormatter
	{
		public static readonly NullableUInt32Formatter Instance;

		private NullableUInt32Formatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, uint? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public uint? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
