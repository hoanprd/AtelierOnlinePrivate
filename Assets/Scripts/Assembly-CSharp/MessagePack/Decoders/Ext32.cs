namespace MessagePack.Decoders
{
	internal sealed class Ext32 : IExtDecoder
	{
		internal static readonly IExtDecoder Instance;

		private Ext32()
		{
		}

		public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionResult);
		}
	}
}
