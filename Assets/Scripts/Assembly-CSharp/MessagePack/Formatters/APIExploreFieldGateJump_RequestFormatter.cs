namespace MessagePack.Formatters
{
	public sealed class APIExploreFieldGateJump_RequestFormatter : IMessagePackFormatter<APIExploreFieldGateJump.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIExploreFieldGateJump.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIExploreFieldGateJump.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
