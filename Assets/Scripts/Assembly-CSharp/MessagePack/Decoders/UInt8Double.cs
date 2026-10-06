namespace MessagePack.Decoders
{
	internal sealed class UInt8Double : IDoubleDecoder
	{
		internal static readonly IDoubleDecoder Instance;

		private UInt8Double()
		{
		}

		public double Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
