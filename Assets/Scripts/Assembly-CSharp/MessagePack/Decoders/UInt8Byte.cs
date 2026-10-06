namespace MessagePack.Decoders
{
	internal sealed class UInt8Byte : IByteDecoder
	{
		internal static readonly IByteDecoder Instance;

		private UInt8Byte()
		{
		}

		public byte Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
