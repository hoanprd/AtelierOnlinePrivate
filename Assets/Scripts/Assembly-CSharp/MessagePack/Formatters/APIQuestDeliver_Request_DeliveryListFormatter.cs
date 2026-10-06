namespace MessagePack.Formatters
{
	public sealed class APIQuestDeliver_Request_DeliveryListFormatter : IMessagePackFormatter<APIQuestDeliver.Request.DeliveryList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIQuestDeliver.Request.DeliveryList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIQuestDeliver.Request.DeliveryList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
