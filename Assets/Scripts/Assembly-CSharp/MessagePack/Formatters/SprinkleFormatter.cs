namespace MessagePack.Formatters
{
	public sealed class SprinkleFormatter : IMessagePackFormatter<Sprinkle>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Sprinkle value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Sprinkle Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
