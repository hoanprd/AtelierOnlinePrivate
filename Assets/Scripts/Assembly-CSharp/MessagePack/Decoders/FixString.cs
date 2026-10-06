namespace MessagePack.Decoders
{
	internal sealed class FixString : IStringDecoder
	{
		internal static readonly IStringDecoder Instance;

		private FixString()
		{
		}

		public string Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
