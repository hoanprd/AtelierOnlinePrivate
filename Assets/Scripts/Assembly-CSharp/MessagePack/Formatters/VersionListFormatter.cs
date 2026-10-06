using MessagePack.Internal;

namespace MessagePack.Formatters
{
	public sealed class VersionListFormatter : IMessagePackFormatter<VersionList>, IMessagePackFormatter
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, VersionList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public VersionList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
