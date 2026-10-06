namespace MessagePack.Decoders
{
	internal sealed class NilBytes : IBytesDecoder
	{
		internal static readonly IBytesDecoder Instance;

		private NilBytes()
		{
		}

		public byte[] Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
