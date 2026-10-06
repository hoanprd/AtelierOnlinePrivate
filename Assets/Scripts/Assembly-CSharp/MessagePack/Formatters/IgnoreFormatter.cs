namespace MessagePack.Formatters
{
	public sealed class IgnoreFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, T value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public T Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(T);
		}
	}
}
