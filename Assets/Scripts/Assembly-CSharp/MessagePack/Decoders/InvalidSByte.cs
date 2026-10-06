namespace MessagePack.Decoders
{
	internal sealed class InvalidSByte : ISByteDecoder
	{
		internal static readonly ISByteDecoder Instance;

		private InvalidSByte()
		{
		}

		public sbyte Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
