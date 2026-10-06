namespace MessagePack.Decoders
{
	internal sealed class FixUInt32 : IUInt32Decoder
	{
		internal static readonly IUInt32Decoder Instance;

		private FixUInt32()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
