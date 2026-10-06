namespace MessagePack.Decoders
{
	internal sealed class Int16Double : IDoubleDecoder
	{
		internal static readonly IDoubleDecoder Instance;

		private Int16Double()
		{
		}

		public double Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
