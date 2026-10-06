namespace MessagePack.Formatters
{
	public sealed class RestoreResponseFormatter : IMessagePackFormatter<RestoreResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RestoreResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RestoreResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
