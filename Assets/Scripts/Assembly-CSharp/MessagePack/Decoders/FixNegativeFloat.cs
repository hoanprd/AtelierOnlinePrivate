namespace MessagePack.Decoders
{
	internal sealed class FixNegativeFloat : ISingleDecoder
	{
		internal static readonly ISingleDecoder Instance;

		private FixNegativeFloat()
		{
		}

		public float Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}
	}
}
