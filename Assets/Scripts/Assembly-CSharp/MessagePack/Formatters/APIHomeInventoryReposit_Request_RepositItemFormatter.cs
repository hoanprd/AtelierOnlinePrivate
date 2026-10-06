namespace MessagePack.Formatters
{
	public sealed class APIHomeInventoryReposit_Request_RepositItemFormatter : IMessagePackFormatter<APIHomeInventoryReposit.Request.RepositItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeInventoryReposit.Request.RepositItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeInventoryReposit.Request.RepositItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
