namespace MessagePack.Decoders
{
	internal sealed class InvalidByte : IByteDecoder
	{
		internal static readonly IByteDecoder Instance;

		private InvalidByte()
		{
		}

		public byte Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
