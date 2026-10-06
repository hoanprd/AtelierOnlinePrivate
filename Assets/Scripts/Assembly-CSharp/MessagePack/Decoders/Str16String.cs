namespace MessagePack.Decoders
{
	internal sealed class Str16String : IStringDecoder
	{
		internal static readonly IStringDecoder Instance;

		private Str16String()
		{
		}

		public string Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
