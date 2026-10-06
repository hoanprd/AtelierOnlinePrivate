namespace MessagePack.Decoders
{
	internal sealed class InvalidBytes : IBytesDecoder
	{
		internal static readonly IBytesDecoder Instance;

		private InvalidBytes()
		{
		}

		public byte[] Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
