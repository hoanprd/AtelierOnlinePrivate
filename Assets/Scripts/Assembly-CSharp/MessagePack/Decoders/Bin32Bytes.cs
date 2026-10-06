namespace MessagePack.Decoders
{
	internal sealed class Bin32Bytes : IBytesDecoder
	{
		internal static readonly IBytesDecoder Instance;

		private Bin32Bytes()
		{
		}

		public byte[] Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
