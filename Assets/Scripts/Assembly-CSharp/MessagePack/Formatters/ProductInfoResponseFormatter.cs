namespace MessagePack.Formatters
{
	public sealed class ProductInfoResponseFormatter : IMessagePackFormatter<ProductInfoResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ProductInfoResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ProductInfoResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
