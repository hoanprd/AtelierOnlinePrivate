using System;

namespace MessagePack.Formatters
{
	public sealed class NullableDateTimeFormatter : IMessagePackFormatter<DateTime?>, IMessagePackFormatter
	{
		public static readonly NullableDateTimeFormatter Instance;

		private NullableDateTimeFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, DateTime? value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DateTime? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
