namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowPotionApply_ItemIDFormatter : IMessagePackFormatter<APIHomeGrowPotionApply.ItemID>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowPotionApply.ItemID value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowPotionApply.ItemID Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
