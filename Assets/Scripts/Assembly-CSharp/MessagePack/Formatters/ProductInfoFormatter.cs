namespace MessagePack.Formatters
{
	public sealed class ProductInfoFormatter : IMessagePackFormatter<ProductInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ProductInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ProductInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
