using MessagePack.Internal;

namespace MessagePack.Formatters
{
	public sealed class VersionHeaderListFormatter : IMessagePackFormatter<VersionHeaderList>, IMessagePackFormatter
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, VersionHeaderList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public VersionHeaderList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
