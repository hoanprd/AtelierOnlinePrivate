using System;

namespace MessagePack.Formatters
{
	public sealed class GuidFormatter : IMessagePackFormatter<Guid>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<Guid> Instance;

		private GuidFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, Guid value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Guid Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(Guid);
		}
	}
}
