namespace MessagePack.Decoders
{
	internal sealed class InvalidExtHeader : IExtHeaderDecoder
	{
		internal static readonly IExtHeaderDecoder Instance;

		private InvalidExtHeader()
		{
		}

		public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionHeader);
		}
	}
}
