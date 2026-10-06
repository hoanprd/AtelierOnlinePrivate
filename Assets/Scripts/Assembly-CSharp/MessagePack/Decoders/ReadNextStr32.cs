namespace MessagePack.Decoders
{
	internal sealed class ReadNextStr32 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextStr32()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
