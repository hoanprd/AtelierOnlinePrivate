using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class LinkedListFormatter<T> : CollectionFormatterBase<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
	{
		protected override void Add(LinkedList<T> collection, int index, T value)
		{
		}

		protected override LinkedList<T> Complete(LinkedList<T> intermediateCollection)
		{
			return null;
		}

		protected override LinkedList<T> Create(int count)
		{
			return null;
		}

		protected override LinkedList<T>.Enumerator GetSourceEnumerator(LinkedList<T> source)
		{
			return default(LinkedList<T>.Enumerator);
		}
	}
}
