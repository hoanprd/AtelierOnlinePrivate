namespace MessagePack.Formatters
{
	public sealed class HomeEnterResponseFormatter : IMessagePackFormatter<HomeEnterResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnterResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnterResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
