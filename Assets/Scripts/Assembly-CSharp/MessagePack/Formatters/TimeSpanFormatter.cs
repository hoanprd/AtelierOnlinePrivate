using System;

namespace MessagePack.Formatters
{
	public sealed class TimeSpanFormatter : IMessagePackFormatter<TimeSpan>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<TimeSpan> Instance;

		private TimeSpanFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, TimeSpan value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TimeSpan Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(TimeSpan);
		}
	}
}
