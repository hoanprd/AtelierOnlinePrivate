using System.Collections;

namespace MessagePack.Formatters
{
	public sealed class NonGenericInterfaceListFormatter : IMessagePackFormatter<IList>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<IList> Instance;

		private NonGenericInterfaceListFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, IList value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public IList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
