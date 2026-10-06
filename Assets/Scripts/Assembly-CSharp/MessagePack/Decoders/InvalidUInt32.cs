namespace MessagePack.Decoders
{
	internal sealed class InvalidUInt32 : IUInt32Decoder
	{
		internal static readonly IUInt32Decoder Instance;

		private InvalidUInt32()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
