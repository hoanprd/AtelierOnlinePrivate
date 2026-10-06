namespace MessagePack.Decoders
{
	internal sealed class ReadNextBin32 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextBin32()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
