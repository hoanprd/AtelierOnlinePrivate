using System;

namespace MessagePack.Internal
{
	internal static class InternalMemoryPool
	{
		[ThreadStatic]
		private static byte[] buffer;

		public static byte[] GetBuffer()
		{
			return null;
		}
	}
}
