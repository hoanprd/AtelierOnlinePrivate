namespace MessagePack.Decoders
{
	internal sealed class FixArrayHeader : IArrayHeaderDecoder
	{
		internal static readonly IArrayHeaderDecoder Instance;

		private FixArrayHeader()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
