using System.Collections;

namespace MessagePack.Formatters
{
	public sealed class NonGenericDictionaryFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter where T : class, IDictionary, new()
	{
		public int Serialize(ref byte[] bytes, int offset, T value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public T Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
