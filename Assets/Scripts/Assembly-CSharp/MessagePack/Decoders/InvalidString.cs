namespace MessagePack.Decoders
{
	internal sealed class InvalidString : IStringDecoder
	{
		internal static readonly IStringDecoder Instance;

		private InvalidString()
		{
		}

		public string Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
