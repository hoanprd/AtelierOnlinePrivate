namespace MessagePack.Decoders
{
	internal sealed class Bin16Bytes : IBytesDecoder
	{
		internal static readonly IBytesDecoder Instance;

		private Bin16Bytes()
		{
		}

		public byte[] Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
