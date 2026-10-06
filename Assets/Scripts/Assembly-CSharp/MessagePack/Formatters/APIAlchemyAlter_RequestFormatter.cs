namespace MessagePack.Formatters
{
	public sealed class APIAlchemyAlter_RequestFormatter : IMessagePackFormatter<APIAlchemyAlter.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIAlchemyAlter.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIAlchemyAlter.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
