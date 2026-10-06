namespace MessagePack.Decoders
{
	internal sealed class NilString : IStringDecoder
	{
		internal static readonly IStringDecoder Instance;

		private NilString()
		{
		}

		public string Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
