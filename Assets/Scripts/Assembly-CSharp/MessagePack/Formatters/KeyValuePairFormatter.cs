using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class KeyValuePairFormatter<TKey, TValue> : IMessagePackFormatter<KeyValuePair<TKey, TValue>>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, KeyValuePair<TKey, TValue> value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public KeyValuePair<TKey, TValue> Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(KeyValuePair<TKey, TValue>);
		}
	}
}
