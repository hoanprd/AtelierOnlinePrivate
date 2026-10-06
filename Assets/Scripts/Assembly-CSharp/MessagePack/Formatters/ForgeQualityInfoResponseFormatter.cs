namespace MessagePack.Formatters
{
	public sealed class ForgeQualityInfoResponseFormatter : IMessagePackFormatter<ForgeQualityInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ForgeQualityInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ForgeQualityInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
