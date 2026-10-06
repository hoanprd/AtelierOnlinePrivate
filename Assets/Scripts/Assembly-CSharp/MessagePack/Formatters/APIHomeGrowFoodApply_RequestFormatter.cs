namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowFoodApply_RequestFormatter : IMessagePackFormatter<APIHomeGrowFoodApply.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowFoodApply.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowFoodApply.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
