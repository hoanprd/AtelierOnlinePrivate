namespace MessagePack.Formatters
{
	public sealed class HuntResultFormatter : IMessagePackFormatter<HuntResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, HuntResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public HuntResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
