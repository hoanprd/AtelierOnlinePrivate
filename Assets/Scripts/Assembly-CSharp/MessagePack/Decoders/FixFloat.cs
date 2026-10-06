namespace MessagePack.Decoders
{
	internal sealed class FixFloat : ISingleDecoder
	{
		internal static readonly ISingleDecoder Instance;

		private FixFloat()
		{
		}

		public float Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
