namespace MessagePack.Decoders
{
	internal sealed class FixSByte : ISByteDecoder
	{
		internal static readonly ISByteDecoder Instance;

		private FixSByte()
		{
		}

		public sbyte Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
