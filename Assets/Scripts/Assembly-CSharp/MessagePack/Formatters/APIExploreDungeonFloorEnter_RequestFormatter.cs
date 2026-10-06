namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonFloorEnter_RequestFormatter : IMessagePackFormatter<APIExploreDungeonFloorEnter.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonFloorEnter.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonFloorEnter.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
