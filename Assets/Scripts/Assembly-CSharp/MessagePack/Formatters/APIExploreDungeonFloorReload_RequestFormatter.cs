namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonFloorReload_RequestFormatter : IMessagePackFormatter<APIExploreDungeonFloorReload.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonFloorReload.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonFloorReload.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
