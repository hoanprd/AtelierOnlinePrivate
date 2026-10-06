using System.Collections;

namespace MessagePack.Formatters
{
	public sealed class BitArrayFormatter : IMessagePackFormatter<BitArray>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<BitArray> Instance;

		private BitArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, BitArray value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BitArray Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
