namespace MessagePack.Formatters
{
	public sealed class HomeEnterFormatter : IMessagePackFormatter<HomeEnter>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
