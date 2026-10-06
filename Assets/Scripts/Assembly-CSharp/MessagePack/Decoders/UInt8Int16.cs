namespace MessagePack.Decoders
{
	internal sealed class UInt8Int16 : IInt16Decoder
	{
		internal static readonly IInt16Decoder Instance;

		private UInt8Int16()
		{
		}

		public short Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}
	}
}
