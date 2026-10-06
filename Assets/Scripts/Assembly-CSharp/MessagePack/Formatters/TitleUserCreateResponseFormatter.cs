namespace MessagePack.Formatters
{
	public sealed class TitleUserCreateResponseFormatter : IMessagePackFormatter<TitleUserCreateResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, TitleUserCreateResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TitleUserCreateResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
