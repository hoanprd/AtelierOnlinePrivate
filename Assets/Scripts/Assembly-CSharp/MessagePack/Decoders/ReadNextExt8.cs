namespace MessagePack.Decoders
{
	internal sealed class ReadNextExt8 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextExt8()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
