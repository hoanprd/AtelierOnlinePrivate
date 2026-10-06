namespace MessagePack.Decoders
{
	internal sealed class ReadNext4 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext4()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
