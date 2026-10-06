namespace MessagePack.Decoders
{
	internal sealed class InvalidMapHeader : IMapHeaderDecoder
	{
		internal static readonly IMapHeaderDecoder Instance;

		private InvalidMapHeader()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
