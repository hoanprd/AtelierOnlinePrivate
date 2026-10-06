namespace MessagePack.Formatters
{
	public sealed class FourDimentionalArrayFormatter<T> : IMessagePackFormatter<T[,,,]>, IMessagePackFormatter
	{
		private const int ArrayLength = 5;

		public int Serialize(ref byte[] bytes, int offset, T[,,,] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public T[,,,] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
