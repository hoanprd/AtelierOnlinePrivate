namespace MessagePack.Decoders
{
	internal sealed class True : IBooleanDecoder
	{
		internal static IBooleanDecoder Instance;

		private True()
		{
		}

		public bool Read()
		{
			return false;
		}
	}
}
