namespace MessagePack.Formatters
{
	public sealed class WealthInfo_CompensationFormatter : IMessagePackFormatter<WealthInfo.Compensation>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, WealthInfo.Compensation value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public WealthInfo.Compensation Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
