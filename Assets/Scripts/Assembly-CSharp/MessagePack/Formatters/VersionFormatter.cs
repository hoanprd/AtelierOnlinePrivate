using System;

namespace MessagePack.Formatters
{
	public sealed class VersionFormatter : IMessagePackFormatter<Version>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<Version> Instance;

		private VersionFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, Version value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Version Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
