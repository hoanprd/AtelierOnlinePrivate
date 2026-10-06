using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class GenericDictionaryFormatter<TKey, TValue, TDictionary> : DictionaryFormatterBase<TKey, TValue, TDictionary, TDictionary> where TDictionary : IDictionary<TKey, TValue>, new()
	{
		protected override void Add(TDictionary collection, int index, TKey key, TValue value)
		{
		}

		protected override TDictionary Complete(TDictionary intermediateCollection)
		{
			return default(TDictionary);
		}

		protected override TDictionary Create(int count)
		{
			return default(TDictionary);
		}
	}
}
