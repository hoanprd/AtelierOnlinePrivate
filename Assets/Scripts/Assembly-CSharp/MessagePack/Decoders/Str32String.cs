namespace MessagePack.Decoders
{
	internal sealed class Str32String : IStringDecoder
	{
		internal static readonly IStringDecoder Instance;

		private Str32String()
		{
		}

		public string Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
