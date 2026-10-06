using System;

namespace MessagePack.Formatters
{
	public sealed class ByteArraySegmentFormatter : IMessagePackFormatter<ArraySegment<byte>>, IMessagePackFormatter
	{
		public static readonly ByteArraySegmentFormatter Instance;

		private ByteArraySegmentFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, ArraySegment<byte> value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ArraySegment<byte> Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}
	}
}
