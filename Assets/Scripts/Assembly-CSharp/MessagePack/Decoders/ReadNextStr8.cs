namespace MessagePack.Decoders
{
	internal sealed class ReadNextStr8 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextStr8()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
