using System;

namespace MessagePack.Formatters
{
	public sealed class NativeDateTimeFormatter : IMessagePackFormatter<DateTime>, IMessagePackFormatter
	{
		public static readonly NativeDateTimeFormatter Instance;

		public int Serialize(ref byte[] bytes, int offset, DateTime value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public DateTime Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(DateTime);
		}
	}
}
