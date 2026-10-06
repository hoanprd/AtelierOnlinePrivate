using System;

namespace MessagePack.Formatters
{
	public sealed class UriFormatter : IMessagePackFormatter<Uri>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<Uri> Instance;

		private UriFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, Uri value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Uri Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
