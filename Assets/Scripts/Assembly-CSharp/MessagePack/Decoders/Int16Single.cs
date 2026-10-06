namespace MessagePack.Decoders
{
	internal sealed class Int16Single : ISingleDecoder
	{
		internal static readonly ISingleDecoder Instance;

		private Int16Single()
		{
		}

		public float Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
