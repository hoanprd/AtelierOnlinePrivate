namespace MessagePack.Decoders
{
	internal sealed class ReadNext18 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext18()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
