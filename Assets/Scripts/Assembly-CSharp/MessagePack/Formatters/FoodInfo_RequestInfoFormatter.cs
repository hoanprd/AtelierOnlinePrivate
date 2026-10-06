namespace MessagePack.Formatters
{
	public sealed class FoodInfo_RequestInfoFormatter : IMessagePackFormatter<FoodInfo.RequestInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FoodInfo.RequestInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FoodInfo.RequestInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
