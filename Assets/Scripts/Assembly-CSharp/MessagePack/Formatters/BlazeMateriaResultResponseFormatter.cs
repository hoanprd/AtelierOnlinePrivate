namespace MessagePack.Formatters
{
	public sealed class BlazeMateriaResultResponseFormatter : IMessagePackFormatter<BlazeMateriaResultResponse>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BlazeMateriaResultResponse value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BlazeMateriaResultResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
