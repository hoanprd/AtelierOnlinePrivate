namespace MessagePack.Formatters
{
	public sealed class APIHomeGrowBlazeartsmateriaApply_ItemIDFormatter : IMessagePackFormatter<APIHomeGrowBlazeartsmateriaApply.ItemID>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIHomeGrowBlazeartsmateriaApply.ItemID value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIHomeGrowBlazeartsmateriaApply.ItemID Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
