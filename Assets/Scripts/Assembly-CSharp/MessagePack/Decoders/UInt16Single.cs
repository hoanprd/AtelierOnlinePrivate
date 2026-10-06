namespace MessagePack.Decoders
{
	internal sealed class UInt16Single : ISingleDecoder
	{
		internal static readonly ISingleDecoder Instance;

		private UInt16Single()
		{
		}

		public float Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
