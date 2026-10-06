namespace MessagePack.Formatters
{
	public sealed class BlazeArtsStatusFormatter : IMessagePackFormatter<BlazeArtsStatus>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BlazeArtsStatus value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BlazeArtsStatus Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
