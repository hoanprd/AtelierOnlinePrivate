namespace MessagePack.Formatters
{
	public sealed class TakeoverCodeResponseFormatter : IMessagePackFormatter<TakeoverCodeResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TakeoverCodeResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TakeoverCodeResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
