namespace MessagePack.Formatters
{
	public sealed class ThreeDimentionalArrayFormatter<T> : IMessagePackFormatter<T[,,]>, IMessagePackFormatter
	{
		private const int ArrayLength = 4;

		public int Serialize(ref byte[] bytes, int offset, T[,,] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public T[,,] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
