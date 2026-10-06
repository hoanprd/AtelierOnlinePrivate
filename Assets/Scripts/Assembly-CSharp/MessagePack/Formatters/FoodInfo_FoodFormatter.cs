namespace MessagePack.Formatters
{
	public sealed class FoodInfo_FoodFormatter : IMessagePackFormatter<FoodInfo.Food>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FoodInfo.Food value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FoodInfo.Food Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
