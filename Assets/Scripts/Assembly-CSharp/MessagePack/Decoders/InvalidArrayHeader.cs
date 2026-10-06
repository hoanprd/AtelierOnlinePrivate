namespace MessagePack.Decoders
{
	internal sealed class InvalidArrayHeader : IArrayHeaderDecoder
	{
		internal static readonly IArrayHeaderDecoder Instance;

		private InvalidArrayHeader()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
