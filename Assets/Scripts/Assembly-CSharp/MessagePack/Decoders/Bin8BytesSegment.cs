using System;

namespace MessagePack.Decoders
{
	internal sealed class Bin8BytesSegment : IBytesSegmentDecoder
	{
		internal static readonly IBytesSegmentDecoder Instance;

		private Bin8BytesSegment()
		{
		}

		public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}
	}
}
