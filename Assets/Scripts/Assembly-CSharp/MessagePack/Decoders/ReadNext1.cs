namespace MessagePack.Decoders
{
	internal sealed class ReadNext1 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext1()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
