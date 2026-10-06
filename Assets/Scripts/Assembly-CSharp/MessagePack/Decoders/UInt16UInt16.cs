namespace MessagePack.Decoders
{
	internal sealed class UInt16UInt16 : IUInt16Decoder
	{
		internal static readonly IUInt16Decoder Instance;

		private UInt16UInt16()
		{
		}

		public ushort Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
