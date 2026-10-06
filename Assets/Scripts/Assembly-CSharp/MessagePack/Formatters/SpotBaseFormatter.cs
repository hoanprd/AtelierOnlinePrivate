namespace MessagePack.Formatters
{
	public sealed class SpotBaseFormatter : IMessagePackFormatter<SpotBase>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, SpotBase value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public SpotBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
