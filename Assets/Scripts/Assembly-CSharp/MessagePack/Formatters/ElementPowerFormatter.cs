namespace MessagePack.Formatters
{
	public sealed class ElementPowerFormatter : IMessagePackFormatter<ElementPower>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, ElementPower value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public ElementPower Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
