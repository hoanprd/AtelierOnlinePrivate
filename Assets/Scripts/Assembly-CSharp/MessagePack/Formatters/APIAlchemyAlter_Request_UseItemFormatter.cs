namespace MessagePack.Formatters
{
	public sealed class APIAlchemyAlter_Request_UseItemFormatter : IMessagePackFormatter<APIAlchemyAlter.Request.UseItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIAlchemyAlter.Request.UseItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIAlchemyAlter.Request.UseItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
