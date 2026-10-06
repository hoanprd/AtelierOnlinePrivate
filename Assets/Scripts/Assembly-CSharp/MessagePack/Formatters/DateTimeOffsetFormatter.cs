using System;

namespace MessagePack.Formatters
{
	public sealed class DateTimeOffsetFormatter : IMessagePackFormatter<DateTimeOffset>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<DateTimeOffset> Instance;

		private DateTimeOffsetFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, DateTimeOffset value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DateTimeOffset Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(DateTimeOffset);
		}
	}
}
