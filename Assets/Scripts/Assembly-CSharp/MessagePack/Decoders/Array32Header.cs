namespace MessagePack.Decoders
{
	internal sealed class Array32Header : IArrayHeaderDecoder
	{
		internal static readonly IArrayHeaderDecoder Instance;

		private Array32Header()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
