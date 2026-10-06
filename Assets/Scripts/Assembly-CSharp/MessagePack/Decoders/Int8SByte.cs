namespace MessagePack.Decoders
{
	internal sealed class Int8SByte : ISByteDecoder
	{
		internal static readonly ISByteDecoder Instance;

		private Int8SByte()
		{
		}

		public sbyte Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
