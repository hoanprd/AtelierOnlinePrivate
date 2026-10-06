namespace MessagePack.Decoders
{
	internal sealed class Ext16 : IExtDecoder
	{
		internal static readonly IExtDecoder Instance;

		private Ext16()
		{
		}

		public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionResult);
		}
	}
}
