namespace MessagePack.Decoders
{
	internal sealed class ReadNextBin16 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextBin16()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
