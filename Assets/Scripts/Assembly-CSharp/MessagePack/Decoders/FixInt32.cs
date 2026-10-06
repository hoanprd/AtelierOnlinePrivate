namespace MessagePack.Decoders
{
	internal sealed class FixInt32 : IInt32Decoder
	{
		internal static readonly IInt32Decoder Instance;

		private FixInt32()
		{
		}

		public int Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
