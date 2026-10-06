namespace MessagePack.Decoders
{
	internal sealed class UInt8Single : ISingleDecoder
	{
		internal static readonly ISingleDecoder Instance;

		private UInt8Single()
		{
		}

		public float Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
