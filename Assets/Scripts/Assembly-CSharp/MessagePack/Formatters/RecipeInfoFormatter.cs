namespace MessagePack.Formatters
{
	public sealed class RecipeInfoFormatter : IMessagePackFormatter<RecipeInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RecipeInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RecipeInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
