namespace MessagePack.Formatters
{
	public sealed class APIComFairyPick_RequestFormatter : IMessagePackFormatter<APIComFairyPick.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFairyPick.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFairyPick.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
