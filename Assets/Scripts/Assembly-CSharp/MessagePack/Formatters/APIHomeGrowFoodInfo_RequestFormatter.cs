namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowFoodInfo_RequestFormatter : IMessagePackFormatter<APIHomeGrowFoodInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowFoodInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowFoodInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
