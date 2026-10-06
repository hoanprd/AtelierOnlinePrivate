namespace MessagePack.Formatters
{
	public sealed class ElementPowerRateFormatter : IMessagePackFormatter<ElementPowerRate>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ElementPowerRate value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ElementPowerRate Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
