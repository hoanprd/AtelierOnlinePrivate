namespace MessagePack.Formatters
{
	public sealed class APIExploreDungeonFloorLeave_RequestFormatter : IMessagePackFormatter<APIExploreDungeonFloorLeave.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreDungeonFloorLeave.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreDungeonFloorLeave.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
