namespace MessagePack.Formatters
{
	public sealed class NullableSingleFormatter : IMessagePackFormatter<float?>, IMessagePackFormatter
	{
		public static readonly NullableSingleFormatter Instance;

		private NullableSingleFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, float? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public float? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
