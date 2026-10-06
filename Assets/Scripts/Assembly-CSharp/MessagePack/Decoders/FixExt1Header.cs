namespace MessagePack.Decoders
{
	internal sealed class FixExt1Header : IExtHeaderDecoder
	{
		internal static readonly IExtHeaderDecoder Instance;

		private FixExt1Header()
		{
		}

		public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionHeader);
		}
	}
}
