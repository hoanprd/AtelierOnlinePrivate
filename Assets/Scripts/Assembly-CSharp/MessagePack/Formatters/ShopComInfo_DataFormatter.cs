namespace MessagePack.Formatters
{
	public sealed class ShopComInfo_DataFormatter : IMessagePackFormatter<ShopComInfo.Data>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ShopComInfo.Data value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ShopComInfo.Data Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
