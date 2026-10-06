namespace MessagePack.Decoders
{
	internal sealed class Ext16Header : IExtHeaderDecoder
	{
		internal static readonly IExtHeaderDecoder Instance;

		private Ext16Header()
		{
		}

		public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionHeader);
		}
	}
}
