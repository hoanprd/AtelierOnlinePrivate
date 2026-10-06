namespace MessagePack.Decoders
{
	internal sealed class ReadNextFixStr : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextFixStr()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
