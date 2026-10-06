namespace MessagePack.Formatters
{
	public sealed class APISpotPickResponseFormatter : IMessagePackFormatter<APISpotPickResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APISpotPickResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APISpotPickResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
