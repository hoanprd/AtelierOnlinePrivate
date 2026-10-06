namespace MessagePack.Decoders
{
	internal sealed class Map16Header : IMapHeaderDecoder
	{
		internal static readonly IMapHeaderDecoder Instance;

		private Map16Header()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
