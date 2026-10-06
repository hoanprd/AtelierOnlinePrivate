namespace MessagePack.Decoders
{
	internal sealed class Ext32Header : IExtHeaderDecoder
	{
		internal static readonly IExtHeaderDecoder Instance;

		private Ext32Header()
		{
		}

		public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionHeader);
		}
	}
}
