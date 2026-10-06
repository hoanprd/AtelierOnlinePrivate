namespace MessagePack.Formatters
{
	public sealed class ParamBaseFormatter : IMessagePackFormatter<ParamBase>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ParamBase value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ParamBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
