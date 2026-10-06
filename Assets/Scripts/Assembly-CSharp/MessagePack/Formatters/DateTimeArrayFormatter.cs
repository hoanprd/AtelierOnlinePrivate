using System;

namespace MessagePack.Formatters
{
	public sealed class DateTimeArrayFormatter : IMessagePackFormatter<DateTime[]>, IMessagePackFormatter
	{
		public static readonly DateTimeArrayFormatter Instance;

		private DateTimeArrayFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, DateTime[] value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DateTime[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
