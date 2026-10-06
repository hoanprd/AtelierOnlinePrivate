namespace MessagePack.Decoders
{
	internal sealed class ReadNext3 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext3()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
