namespace MessagePack.Formatters
{
	public sealed class GachaInfo_DataFormatter : IMessagePackFormatter<GachaInfo.Data>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, GachaInfo.Data value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public GachaInfo.Data Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
