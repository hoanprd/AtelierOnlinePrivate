namespace MessagePack.Decoders
{
	internal sealed class ReadNextExt32 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextExt32()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
