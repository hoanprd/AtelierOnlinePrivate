namespace MessagePack.Formatters
{
	public sealed class APISpotPickData_ItemInfoFormatter : IMessagePackFormatter<APISpotPickData.ItemInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APISpotPickData.ItemInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APISpotPickData.ItemInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
