namespace MessagePack.Decoders
{
	internal sealed class FixExt1 : IExtDecoder
	{
		internal static readonly IExtDecoder Instance;

		private FixExt1()
		{
		}

		public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionResult);
		}
	}
}
