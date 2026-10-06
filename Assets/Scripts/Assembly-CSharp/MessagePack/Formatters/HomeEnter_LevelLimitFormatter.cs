namespace MessagePack.Formatters
{
	public sealed class HomeEnter_LevelLimitFormatter : IMessagePackFormatter<HomeEnter.LevelLimit>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter.LevelLimit value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter.LevelLimit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
