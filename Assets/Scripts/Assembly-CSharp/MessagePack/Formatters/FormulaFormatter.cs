namespace MessagePack.Formatters
{
	public sealed class FormulaFormatter : IMessagePackFormatter<Formula>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, Formula value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public Formula Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
