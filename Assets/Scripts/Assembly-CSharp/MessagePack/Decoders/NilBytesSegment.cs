using System;

namespace MessagePack.Decoders
{
	internal sealed class NilBytesSegment : IBytesSegmentDecoder
	{
		internal static readonly IBytesSegmentDecoder Instance;

		private NilBytesSegment()
		{
		}

		public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}
	}
}
