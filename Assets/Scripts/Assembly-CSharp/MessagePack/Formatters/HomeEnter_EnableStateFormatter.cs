namespace MessagePack.Formatters
{
	public sealed class HomeEnter_EnableStateFormatter : IMessagePackFormatter<HomeEnter.EnableState>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter.EnableState value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter.EnableState Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
