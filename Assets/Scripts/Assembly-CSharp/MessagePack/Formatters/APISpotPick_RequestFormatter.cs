namespace MessagePack.Formatters
{
	public sealed class APISpotPick_RequestFormatter : IMessagePackFormatter<APISpotPick.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APISpotPick.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APISpotPick.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
