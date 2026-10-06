namespace MessagePack.Formatters
{
	public sealed class ProductionInfoFormatter : IMessagePackFormatter<ProductionInfo>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ProductionInfo value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ProductionInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
