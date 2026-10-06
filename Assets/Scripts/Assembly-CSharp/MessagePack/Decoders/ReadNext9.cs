namespace MessagePack.Decoders
{
	internal sealed class ReadNext9 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext9()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
