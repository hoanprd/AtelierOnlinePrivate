namespace MessagePack.Formatters
{
	public sealed class ForgeResultResponseFormatter : IMessagePackFormatter<ForgeResultResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ForgeResultResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ForgeResultResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
