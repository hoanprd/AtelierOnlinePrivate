using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class SortedDictionaryFormatter<TKey, TValue> : DictionaryFormatterBase<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>>
	{
		protected override void Add(SortedDictionary<TKey, TValue> collection, int index, TKey key, TValue value)
		{
		}

		protected override SortedDictionary<TKey, TValue> Complete(SortedDictionary<TKey, TValue> intermediateCollection)
		{
			return null;
		}

		protected override SortedDictionary<TKey, TValue> Create(int count)
		{
			return null;
		}
	}
}
