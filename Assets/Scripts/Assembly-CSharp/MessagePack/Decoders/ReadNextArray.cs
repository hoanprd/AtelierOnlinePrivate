namespace MessagePack.Decoders
{
	internal sealed class ReadNextArray : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextArray()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
