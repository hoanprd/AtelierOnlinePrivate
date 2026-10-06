namespace MessagePack.Decoders
{
	internal sealed class ReadNextStr16 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextStr16()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
