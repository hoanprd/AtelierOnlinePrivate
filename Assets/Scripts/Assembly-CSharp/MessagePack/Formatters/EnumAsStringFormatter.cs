using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class EnumAsStringFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter
	{
		private readonly Dictionary<string, T> nameValueMapping;

		private readonly Dictionary<T, string> valueNameMapping;

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
