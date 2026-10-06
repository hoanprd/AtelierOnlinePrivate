namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowExceedApply_RequestFormatter : IMessagePackFormatter<APIHomeGrowExceedApply.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowExceedApply.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowExceedApply.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
