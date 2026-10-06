namespace MessagePack.Decoders
{
	internal sealed class UInt32Single : ISingleDecoder
	{
		internal static readonly ISingleDecoder Instance;

		private UInt32Single()
		{
		}

		public float Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
