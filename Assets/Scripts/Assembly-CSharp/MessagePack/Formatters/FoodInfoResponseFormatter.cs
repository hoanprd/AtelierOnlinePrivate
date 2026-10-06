namespace MessagePack.Formatters
{
	public sealed class FoodInfoResponseFormatter : IMessagePackFormatter<FoodInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FoodInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FoodInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
