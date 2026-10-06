namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowPotionInfo_RequestFormatter : IMessagePackFormatter<APIHomeGrowPotionInfo.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowPotionInfo.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowPotionInfo.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
