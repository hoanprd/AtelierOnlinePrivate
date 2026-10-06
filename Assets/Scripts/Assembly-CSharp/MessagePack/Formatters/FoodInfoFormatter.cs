namespace MessagePack.Formatters
{
	public sealed class FoodInfoFormatter : IMessagePackFormatter<FoodInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FoodInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FoodInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
