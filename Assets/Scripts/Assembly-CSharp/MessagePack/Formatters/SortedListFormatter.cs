using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class SortedListFormatter<TKey, TValue> : DictionaryFormatterBase<TKey, TValue, SortedList<TKey, TValue>, SortedList<TKey, TValue>>
	{
		protected override void Add(SortedList<TKey, TValue> collection, int index, TKey key, TValue value)
		{
		}

		protected override SortedList<TKey, TValue> Complete(SortedList<TKey, TValue> intermediateCollection)
		{
			return null;
		}

		protected override SortedList<TKey, TValue> Create(int count)
		{
			return null;
		}
	}
}
