namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonFloorCreate_Request_PosInfoFormatter : IMessagePackFormatter<APIExploreDungeonFloorCreate.Request.PosInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonFloorCreate.Request.PosInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonFloorCreate.Request.PosInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
