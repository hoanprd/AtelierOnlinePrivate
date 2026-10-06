namespace MessagePack.Formatters
{
	public sealed class APIItemHeal_RequestFormatter : IMessagePackFormatter<APIItemHeal.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIItemHeal.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIItemHeal.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
