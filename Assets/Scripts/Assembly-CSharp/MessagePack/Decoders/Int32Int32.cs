namespace MessagePack.Decoders
{
	internal sealed class Int32Int32 : IInt32Decoder
	{
		internal static readonly IInt32Decoder Instance;

		private Int32Int32()
		{
		}

		public int Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
