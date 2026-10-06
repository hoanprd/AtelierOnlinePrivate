namespace MessagePack.Decoders
{
	internal sealed class FixUInt16 : IUInt16Decoder
	{
		internal static readonly IUInt16Decoder Instance;

		private FixUInt16()
		{
		}

		public ushort Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
