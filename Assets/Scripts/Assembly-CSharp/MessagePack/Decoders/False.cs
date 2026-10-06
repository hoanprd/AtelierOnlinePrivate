namespace MessagePack.Decoders
{
	internal sealed class False : IBooleanDecoder
	{
		internal static IBooleanDecoder Instance;

		private False()
		{
		}

		public bool Read()
		{
			return false;
		}
	}
}
