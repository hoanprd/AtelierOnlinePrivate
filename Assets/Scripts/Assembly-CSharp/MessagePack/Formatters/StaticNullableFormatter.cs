namespace MessagePack.Formatters
{
	public sealed class StaticNullableFormatter<T> : IMessagePackFormatter<T?>, IMessagePackFormatter where T : struct
	{
		private readonly IMessagePackFormatter<T> underlyingFormatter;

		public StaticNullableFormatter(IMessagePackFormatter<T> underlyingFormatter)
		{
		}

		public int Serialize(ref byte[] bytes, int offset, T? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public T? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
