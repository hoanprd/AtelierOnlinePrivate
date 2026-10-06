namespace MessagePack.Decoders
{
	internal sealed class ReadNext6 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext6()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
