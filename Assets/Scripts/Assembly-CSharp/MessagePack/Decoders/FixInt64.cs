namespace MessagePack.Decoders
{
	internal sealed class FixInt64 : IInt64Decoder
	{
		internal static readonly IInt64Decoder Instance;

		private FixInt64()
		{
		}

		public long Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0L;
		}
	}
}
