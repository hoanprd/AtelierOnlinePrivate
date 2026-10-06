namespace MessagePack.Decoders
{
	internal sealed class FixExt2Header : IExtHeaderDecoder
	{
		internal static readonly IExtHeaderDecoder Instance;

		private FixExt2Header()
		{
		}

		public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionHeader);
		}
	}
}
