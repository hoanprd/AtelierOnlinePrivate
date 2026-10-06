namespace MessagePack.Formatters
{
	public sealed class FoodResult_ResultFormatter : IMessagePackFormatter<FoodResult.Result>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FoodResult.Result value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FoodResult.Result Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
