namespace MessagePack.Formatters
{
	public sealed class APISpotPickDataFormatter : IMessagePackFormatter<APISpotPickData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APISpotPickData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APISpotPickData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
