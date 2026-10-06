namespace MessagePack.Formatters
{
	public sealed class RecipeAlterInfoFormatter : IMessagePackFormatter<RecipeAlterInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, RecipeAlterInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public RecipeAlterInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
