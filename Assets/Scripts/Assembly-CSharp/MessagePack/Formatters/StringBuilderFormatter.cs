using System.Text;

namespace MessagePack.Formatters
{
	public sealed class StringBuilderFormatter : IMessagePackFormatter<StringBuilder>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<StringBuilder> Instance;

		private StringBuilderFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, StringBuilder value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public StringBuilder Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
