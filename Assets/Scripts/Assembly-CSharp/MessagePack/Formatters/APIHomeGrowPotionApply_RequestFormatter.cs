namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowPotionApply_RequestFormatter : IMessagePackFormatter<APIHomeGrowPotionApply.Request>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowPotionApply.Request value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowPotionApply.Request Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
