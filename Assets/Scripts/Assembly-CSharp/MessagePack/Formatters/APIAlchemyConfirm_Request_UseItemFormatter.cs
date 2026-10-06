namespace MessagePack.Formatters
{
	public sealed class APIAlchemyConfirm_Request_UseItemFormatter : IMessagePackFormatter<APIAlchemyConfirm.Request.UseItem>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIAlchemyConfirm.Request.UseItem value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIAlchemyConfirm.Request.UseItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
