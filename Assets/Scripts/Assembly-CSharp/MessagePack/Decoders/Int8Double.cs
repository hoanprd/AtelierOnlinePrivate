namespace MessagePack.Decoders
{
	internal sealed class Int8Double : IDoubleDecoder
	{
		internal static readonly IDoubleDecoder Instance;

		private Int8Double()
		{
		}

		public double Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
