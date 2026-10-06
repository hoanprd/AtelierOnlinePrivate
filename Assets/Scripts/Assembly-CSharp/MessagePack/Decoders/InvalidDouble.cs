namespace MessagePack.Decoders
{
	internal sealed class InvalidDouble : IDoubleDecoder
	{
		internal static readonly IDoubleDecoder Instance;

		private InvalidDouble()
		{
		}

		public double Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}
	}
}
