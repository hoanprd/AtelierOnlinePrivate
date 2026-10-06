using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class HashSetFormatter<T> : CollectionFormatterBase<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
	{
		protected override int? GetCount(HashSet<T> sequence)
		{
			return null;
		}

		protected override void Add(HashSet<T> collection, int index, T value)
		{
		}

		protected override HashSet<T> Complete(HashSet<T> intermediateCollection)
		{
			return null;
		}

		protected override HashSet<T> Create(int count)
		{
			return null;
		}

		protected override HashSet<T>.Enumerator GetSourceEnumerator(HashSet<T> source)
		{
			return default(HashSet<T>.Enumerator);
		}
	}
}
