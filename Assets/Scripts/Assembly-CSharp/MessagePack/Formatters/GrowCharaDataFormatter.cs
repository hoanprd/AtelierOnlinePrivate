namespace MessagePack.Formatters
{
	public sealed class GrowCharaDataFormatter : IMessagePackFormatter<GrowCharaData>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GrowCharaData value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GrowCharaData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
