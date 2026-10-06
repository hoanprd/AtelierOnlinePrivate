using System;

namespace MessagePack.Decoders
{
	internal sealed class FixStringSegment : IStringSegmentDecoder
	{
		internal static readonly IStringSegmentDecoder Instance;

		private FixStringSegment()
		{
		}

		public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}
	}
}
