namespace MessagePack.Formatters
{
	public sealed class IngredientFormatter : IMessagePackFormatter<Ingredient>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Ingredient value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Ingredient Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
