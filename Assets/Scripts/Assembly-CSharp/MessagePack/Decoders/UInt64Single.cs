namespace MessagePack.Decoders
{
	internal sealed class UInt64Single : ISingleDecoder
	{
		internal static readonly ISingleDecoder Instance;

		private UInt64Single()
		{
		}

		public float Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
