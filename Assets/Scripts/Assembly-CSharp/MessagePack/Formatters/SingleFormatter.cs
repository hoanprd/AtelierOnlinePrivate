namespace MessagePack.Formatters
{
	public sealed class SingleFormatter : IMessagePackFormatter<float>, IMessagePackFormatter
	{
		public static readonly SingleFormatter Instance;

		private SingleFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, float value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public float Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
