namespace MessagePack.Formatters
{
	public sealed class FairyPickResponseFormatter : IMessagePackFormatter<FairyPickResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, FairyPickResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public FairyPickResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
