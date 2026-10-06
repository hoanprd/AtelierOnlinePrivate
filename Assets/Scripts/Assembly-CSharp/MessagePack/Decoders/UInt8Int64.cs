namespace MessagePack.Decoders
{
	internal sealed class UInt8Int64 : IInt64Decoder
	{
		internal static readonly IInt64Decoder Instance;

		private UInt8Int64()
		{
		}

		public long Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0L;
		}
	}
}
