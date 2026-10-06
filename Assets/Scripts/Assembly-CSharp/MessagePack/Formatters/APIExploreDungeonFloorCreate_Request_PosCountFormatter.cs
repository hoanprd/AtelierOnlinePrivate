namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonFloorCreate_Request_PosCountFormatter : IMessagePackFormatter<APIExploreDungeonFloorCreate.Request.PosCount>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonFloorCreate.Request.PosCount value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonFloorCreate.Request.PosCount Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
