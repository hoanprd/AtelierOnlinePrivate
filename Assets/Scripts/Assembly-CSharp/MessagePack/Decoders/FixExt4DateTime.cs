using System;

namespace MessagePack.Decoders
{
	internal sealed class FixExt4DateTime : IDateTimeDecoder
	{
		internal static readonly IDateTimeDecoder Instance;

		private FixExt4DateTime()
		{
		}

		public DateTime Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(DateTime);
		}
	}
}
