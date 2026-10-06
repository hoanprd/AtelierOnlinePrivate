namespace MessagePack.Decoders
{
	internal sealed class UInt32UInt32 : IUInt32Decoder
	{
		internal static readonly IUInt32Decoder Instance;

		private UInt32UInt32()
		{
		}

		public uint Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}
	}
}
