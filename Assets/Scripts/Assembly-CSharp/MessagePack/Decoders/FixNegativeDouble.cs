namespace MessagePack.Decoders
{
	internal sealed class FixNegativeDouble : IDoubleDecoder
	{
		internal static readonly IDoubleDecoder Instance;

		private FixNegativeDouble()
		{
		}

		public double Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
