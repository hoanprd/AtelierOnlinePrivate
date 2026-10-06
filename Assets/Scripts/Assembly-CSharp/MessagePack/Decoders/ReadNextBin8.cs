namespace MessagePack.Decoders
{
	internal sealed class ReadNextBin8 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextBin8()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
