using System;

namespace MessagePack.Decoders
{
	internal sealed class Str16StringSegment : IStringSegmentDecoder
	{
		internal static readonly IStringSegmentDecoder Instance;

		private Str16StringSegment()
		{
		}

		public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}
	}
}
