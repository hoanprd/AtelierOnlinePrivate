using System.Collections;

namespace MessagePack.Formatters
{
	public sealed class NonGenericInterfaceDictionaryFormatter : IMessagePackFormatter<IDictionary>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<IDictionary> Instance;

		private NonGenericInterfaceDictionaryFormatter()
		{
		}

		public int Serialize(ref byte[] bytes, int offset, IDictionary value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public IDictionary Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
