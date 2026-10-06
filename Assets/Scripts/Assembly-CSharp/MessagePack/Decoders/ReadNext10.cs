namespace MessagePack.Decoders
{
	internal sealed class ReadNext10 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNext10()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
