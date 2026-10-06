using System;

namespace MessagePack.Decoders
{
	internal sealed class InvalidStringSegment : IStringSegmentDecoder
	{
		internal static readonly IStringSegmentDecoder Instance;

		private InvalidStringSegment()
		{
		}

		public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}
	}
}
