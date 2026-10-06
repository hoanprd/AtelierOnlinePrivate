namespace MessagePack.Decoders
{
	internal sealed class ReadNextExt16 : IReadNextDecoder
	{
		internal static readonly IReadNextDecoder Instance;

		private ReadNextExt16()
		{
		}

		public int Read(byte[] bytes, int offset)
		{
			return 0;
		}
	}
}
