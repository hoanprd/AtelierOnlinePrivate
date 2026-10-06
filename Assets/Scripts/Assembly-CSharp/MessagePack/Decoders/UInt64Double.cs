namespace MessagePack.Decoders
{
	internal sealed class UInt64Double : IDoubleDecoder
	{
		internal static readonly IDoubleDecoder Instance;

		private UInt64Double()
		{
		}

		public double Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
