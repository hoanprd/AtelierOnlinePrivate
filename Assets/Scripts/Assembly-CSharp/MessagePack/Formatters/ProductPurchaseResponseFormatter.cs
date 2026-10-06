namespace MessagePack.Formatters
{
	public sealed class ProductPurchaseResponseFormatter : IMessagePackFormatter<ProductPurchaseResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ProductPurchaseResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ProductPurchaseResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
