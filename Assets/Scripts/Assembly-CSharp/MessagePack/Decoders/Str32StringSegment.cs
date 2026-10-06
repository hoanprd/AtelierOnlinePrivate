using System;

namespace MessagePack.Decoders
{
	internal sealed class Str32StringSegment : IStringSegmentDecoder
	{
		internal static readonly IStringSegmentDecoder Instance;

		private Str32StringSegment()
		{
		}

		public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}
	}
}
