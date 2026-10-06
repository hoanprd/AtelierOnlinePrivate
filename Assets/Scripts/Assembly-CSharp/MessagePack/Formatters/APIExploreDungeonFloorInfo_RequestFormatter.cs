namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonFloorInfo_RequestFormatter : IMessagePackFormatter<APIExploreDungeonFloorInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonFloorInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonFloorInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
