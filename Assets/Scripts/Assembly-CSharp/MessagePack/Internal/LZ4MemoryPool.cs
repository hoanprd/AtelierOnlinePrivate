using System;

namespace MessagePack.Internal
{
	internal static class LZ4MemoryPool
	{
		[ThreadStatic]
		private static byte[] lz4buffer;

		public static byte[] GetBuffer()
		{
			return null;
		}
	}
}
