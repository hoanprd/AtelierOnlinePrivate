namespace MessagePack.Decoders
{
	internal sealed class InvalidInt64 : IInt64Decoder
	{
		internal static readonly IInt64Decoder Instance;

		private InvalidInt64()
		{
		}

		public long Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0L;
		}
	}
}
