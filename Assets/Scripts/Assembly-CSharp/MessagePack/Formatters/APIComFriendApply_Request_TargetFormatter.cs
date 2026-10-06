namespace MessagePack.Formatters
{
	public sealed class APIComFriendApply_Request_TargetFormatter : IMessagePackFormatter<APIComFriendApply.Request.Target>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIComFriendApply.Request.Target value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIComFriendApply.Request.Target Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
