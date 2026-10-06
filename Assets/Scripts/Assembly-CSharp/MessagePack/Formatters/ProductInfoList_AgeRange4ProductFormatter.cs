namespace MessagePack.Formatters
{
	public sealed class ProductInfoList_AgeRange4ProductFormatter : IMessagePackFormatter<ProductInfoList.AgeRange4Product>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ProductInfoList.AgeRange4Product value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ProductInfoList.AgeRange4Product Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
