namespace MessagePack.Formatters
{
	public sealed class ExploreFieldQuestDeliverResponseFormatter : IMessagePackFormatter<ExploreFieldQuestDeliverResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ExploreFieldQuestDeliverResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ExploreFieldQuestDeliverResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
