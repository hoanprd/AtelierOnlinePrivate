using System;

namespace MessagePack.Decoders
{
	internal sealed class FixExt8DateTime : IDateTimeDecoder
	{
		internal static readonly IDateTimeDecoder Instance;

		private FixExt8DateTime()
		{
		}

		public DateTime Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(DateTime);
		}
	}
}
