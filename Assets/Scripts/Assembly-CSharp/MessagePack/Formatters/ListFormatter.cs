using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class ListFormatter<T> : IMessagePackFormatter<List<T>>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, List<T> value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public List<T> Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
