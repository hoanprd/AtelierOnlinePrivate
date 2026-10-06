namespace MessagePack.Formatters
{
	public sealed class TakeoverCodeFormatter : IMessagePackFormatter<TakeoverCode>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TakeoverCode value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TakeoverCode Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
