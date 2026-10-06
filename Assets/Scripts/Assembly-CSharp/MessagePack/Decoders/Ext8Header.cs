namespace MessagePack.Decoders
{
	internal sealed class Ext8Header : IExtHeaderDecoder
	{
		internal static readonly IExtHeaderDecoder Instance;

		private Ext8Header()
		{
		}

		public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionHeader);
		}
	}
}
