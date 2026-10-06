namespace MessagePack.Decoders
{
	internal sealed class Array16Header : IArrayHeaderDecoder
	{
		internal static readonly IArrayHeaderDecoder Instance;

		private Array16Header()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
