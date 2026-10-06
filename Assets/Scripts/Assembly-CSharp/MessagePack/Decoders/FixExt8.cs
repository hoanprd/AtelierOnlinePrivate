namespace MessagePack.Decoders
{
	internal sealed class FixExt8 : IExtDecoder
	{
		internal static readonly IExtDecoder Instance;

		private FixExt8()
		{
		}

		public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionResult);
		}
	}
}
