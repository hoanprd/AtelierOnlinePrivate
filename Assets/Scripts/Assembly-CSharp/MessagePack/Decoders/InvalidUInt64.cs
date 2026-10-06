namespace MessagePack.Decoders
{
	internal sealed class InvalidUInt64 : IUInt64Decoder
	{
		internal static readonly IUInt64Decoder Instance;

		private InvalidUInt64()
		{
		}

		public ulong Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0uL;
		}
	}
}
