namespace MessagePack.Formatters
{
	public sealed class eHuntReturnTypeFormatter : IMessagePackFormatter<eHuntReturnType>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, eHuntReturnType value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public eHuntReturnType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return eHuntReturnType.TimeElapsed;
		}
	}
}
