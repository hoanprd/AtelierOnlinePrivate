namespace MessagePack.Decoders
{
	internal sealed class Map32Header : IMapHeaderDecoder
	{
		internal static readonly IMapHeaderDecoder Instance;

		private Map32Header()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
