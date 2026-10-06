namespace MessagePack.Decoders
{
	internal sealed class FixByte : IByteDecoder
	{
		internal static readonly IByteDecoder Instance;

		private FixByte()
		{
		}

		public byte Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
