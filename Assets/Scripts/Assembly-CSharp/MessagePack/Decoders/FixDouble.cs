namespace MessagePack.Decoders
{
	internal sealed class FixDouble : IDoubleDecoder
	{
		internal static readonly IDoubleDecoder Instance;

		private FixDouble()
		{
		}

		public double Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
