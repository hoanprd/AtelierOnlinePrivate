namespace MessagePack.Formatters
{
	public sealed class FoodResultResponseFormatter : IMessagePackFormatter<FoodResultResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FoodResultResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FoodResultResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
