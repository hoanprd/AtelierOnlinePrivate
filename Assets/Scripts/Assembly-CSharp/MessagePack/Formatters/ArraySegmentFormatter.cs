using System;

namespace MessagePack.Formatters
{
	public sealed class ArraySegmentFormatter<T> : IMessagePackFormatter<ArraySegment<T>>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ArraySegment<T> value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ArraySegment<T> Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<T>);
		}
	}
}
