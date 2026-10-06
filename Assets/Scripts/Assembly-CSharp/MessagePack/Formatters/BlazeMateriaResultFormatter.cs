namespace MessagePack.Formatters
{
	public sealed class BlazeMateriaResultFormatter : IMessagePackFormatter<BlazeMateriaResult>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BlazeMateriaResult value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BlazeMateriaResult Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
