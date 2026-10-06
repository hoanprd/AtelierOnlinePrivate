namespace MessagePack.Decoders
{
	internal sealed class ReadNextMap : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextMap()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
