namespace MessagePack.Decoders
{
	internal sealed class FixNegativeInt16 : IInt16Decoder
	{
		internal static readonly IInt16Decoder Instance;

		private FixNegativeInt16()
		{
		}

		public short Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
