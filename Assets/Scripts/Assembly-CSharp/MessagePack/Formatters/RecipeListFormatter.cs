namespace MessagePack.Formatters
{
	public sealed class RecipeListFormatter : IMessagePackFormatter<RecipeList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RecipeList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RecipeList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
