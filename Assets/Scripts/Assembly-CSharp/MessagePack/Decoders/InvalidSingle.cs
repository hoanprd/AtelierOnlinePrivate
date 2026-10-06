namespace MessagePack.Decoders
{
	internal sealed class InvalidSingle : ISingleDecoder
	{
		internal static readonly ISingleDecoder Instance;

		private InvalidSingle()
		{
		}

		public float Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
