namespace MessagePack.Decoders
{
	internal sealed class InvalidBoolean : IBooleanDecoder
	{
		internal static IBooleanDecoder Instance;

		private InvalidBoolean()
		{
		}

		public bool Read()
		{
			return false;
		}
	}
}
