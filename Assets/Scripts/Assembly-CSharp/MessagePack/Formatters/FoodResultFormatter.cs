namespace MessagePack.Formatters
{
	public sealed class FoodResultFormatter : IMessagePackFormatter<FoodResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FoodResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FoodResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
