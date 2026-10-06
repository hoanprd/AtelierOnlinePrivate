using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public abstract class DictionaryFormatterBase<TKey, TValue, TIntermediate, TDictionary> : IMessagePackFormatter<TDictionary>, IMessagePackFormatter where TDictionary : IDictionary<TKey, TValue>
	{
		public int Serialize(ref byte[] bytes, int offset, TDictionary value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TDictionary Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(TDictionary);
		}

		protected abstract TIntermediate Create(int count);

		protected abstract void Add(TIntermediate collection, int index, TKey key, TValue value);

		protected abstract TDictionary Complete(TIntermediate intermediateCollection);
	}
}
