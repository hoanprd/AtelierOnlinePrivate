namespace MessagePack.Decoders
{
	internal sealed class Bin8Bytes : IBytesDecoder
	{
		internal static readonly IBytesDecoder Instance;

		private Bin8Bytes()
		{
		}

		public byte[] Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
