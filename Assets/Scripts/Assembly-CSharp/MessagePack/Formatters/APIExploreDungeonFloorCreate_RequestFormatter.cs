namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonFloorCreate_RequestFormatter : IMessagePackFormatter<APIExploreDungeonFloorCreate.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonFloorCreate.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonFloorCreate.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
