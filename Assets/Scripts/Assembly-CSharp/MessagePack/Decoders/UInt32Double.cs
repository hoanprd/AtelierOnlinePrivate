namespace MessagePack.Decoders
{
	internal sealed class UInt32Double : IDoubleDecoder
	{
		internal static readonly IDoubleDecoder Instance;

		private UInt32Double()
		{
		}

		public double Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
