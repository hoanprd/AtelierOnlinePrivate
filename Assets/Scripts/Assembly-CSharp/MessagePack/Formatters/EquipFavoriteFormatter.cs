namespace MessagePack.Formatters
{
	public sealed class EquipFavoriteFormatter : IMessagePackFormatter<EquipFavorite>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EquipFavorite value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EquipFavorite Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
