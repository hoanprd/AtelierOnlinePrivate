namespace MessagePack.Formatters
{
	public sealed class ForgeInfoResponseFormatter : IMessagePackFormatter<ForgeInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ForgeInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ForgeInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
