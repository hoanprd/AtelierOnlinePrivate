namespace MessagePack.Decoders
{
	internal sealed class UInt64Int64 : IInt64Decoder
	{
		internal static readonly IInt64Decoder Instance;

		private UInt64Int64()
		{
		}

		public long Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0L;
		}
	}
}
