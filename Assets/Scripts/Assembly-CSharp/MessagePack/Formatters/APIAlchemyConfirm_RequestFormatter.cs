namespace MessagePack.Formatters
{
	public sealed class APIAlchemyConfirm_RequestFormatter : IMessagePackFormatter<APIAlchemyConfirm.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIAlchemyConfirm.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIAlchemyConfirm.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
