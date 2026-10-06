namespace MessagePack.Formatters
{
	public sealed class HomeEnter_PresetnInfoFormatter : IMessagePackFormatter<HomeEnter.PresetnInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HomeEnter.PresetnInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HomeEnter.PresetnInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
