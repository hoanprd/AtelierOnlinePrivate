using System;

namespace MessagePack.Decoders
{
	internal sealed class Ext8DateTime : IDateTimeDecoder
	{
		internal static readonly IDateTimeDecoder Instance;

		private Ext8DateTime()
		{
		}

		public DateTime Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(DateTime);
		}
	}
}
