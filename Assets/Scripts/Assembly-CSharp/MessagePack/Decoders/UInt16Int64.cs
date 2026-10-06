namespace MessagePack.Decoders
{
	internal sealed class UInt16Int64 : IInt64Decoder
	{
		internal static readonly IInt64Decoder Instance;

		private UInt16Int64()
		{
		}

		public long Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0L;
		}
	}
}
