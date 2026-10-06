namespace MessagePack.Decoders
{
	internal sealed class FixMapHeader : IMapHeaderDecoder
	{
		internal static readonly IMapHeaderDecoder Instance;

		private FixMapHeader()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
