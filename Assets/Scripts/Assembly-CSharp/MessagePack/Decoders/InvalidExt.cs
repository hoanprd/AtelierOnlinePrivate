namespace MessagePack.Decoders
{
	internal sealed class InvalidExt : IExtDecoder
	{
		internal static readonly IExtDecoder Instance;

		private InvalidExt()
		{
		}

		public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionResult);
		}
	}
}
