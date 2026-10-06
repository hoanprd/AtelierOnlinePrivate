namespace MessagePack.Formatters
{
	public sealed class ProductInfoListFormatter : IMessagePackFormatter<ProductInfoList>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ProductInfoList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ProductInfoList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
