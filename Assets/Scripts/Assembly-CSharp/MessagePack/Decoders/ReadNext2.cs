namespace MessagePack.Decoders
{
	internal sealed class ReadNext2 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext2()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
