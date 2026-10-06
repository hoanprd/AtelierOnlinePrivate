namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowFoodApply_ItemIDFormatter : IMessagePackFormatter<APIHomeGrowFoodApply.ItemID>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowFoodApply.ItemID value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowFoodApply.ItemID Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
