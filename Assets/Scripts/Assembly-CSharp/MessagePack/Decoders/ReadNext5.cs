namespace MessagePack.Decoders
{
	internal sealed class ReadNext5 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext5()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
