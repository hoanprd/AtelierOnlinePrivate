namespace MessagePack.Decoders
{
	internal sealed class Ext8 : IExtDecoder
	{
		internal static readonly IExtDecoder Instance;

		private Ext8()
		{
		}

		public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionResult);
		}
	}
}
