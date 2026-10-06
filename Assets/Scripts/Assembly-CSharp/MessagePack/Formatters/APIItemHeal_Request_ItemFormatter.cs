namespace MessagePack.Formatters
{
	public sealed class APIItemHeal_Request_ItemFormatter : IMessagePackFormatter<APIItemHeal.Request.Item>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIItemHeal.Request.Item value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIItemHeal.Request.Item Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
