namespace MessagePack.Decoders
{
	internal sealed class Int8Int32 : IInt32Decoder
	{
		internal static readonly IInt32Decoder Instance;

		private Int8Int32()
		{
		}

		public int Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
