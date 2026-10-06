namespace MessagePack.Formatters
{
	public sealed class APIAlchemyRecipe_RequestFormatter : IMessagePackFormatter<APIAlchemyRecipe.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIAlchemyRecipe.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIAlchemyRecipe.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
