using System.Linq;

namespace MessagePack.Formatters
{
	public sealed class InterfaceGroupingFormatter<TKey, TElement> : IMessagePackFormatter<IGrouping<TKey, TElement>>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, IGrouping<TKey, TElement> value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public IGrouping<TKey, TElement> Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
