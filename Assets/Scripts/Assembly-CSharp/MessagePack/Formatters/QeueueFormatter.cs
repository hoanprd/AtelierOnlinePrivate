using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class QeueueFormatter<T> : CollectionFormatterBase<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
	{
		protected override int? GetCount(Queue<T> sequence)
		{
			return null;
		}

		protected override void Add(Queue<T> collection, int index, T value)
		{
		}

		protected override Queue<T> Create(int count)
		{
			return null;
		}

		protected override Queue<T>.Enumerator GetSourceEnumerator(Queue<T> source)
		{
			return default(Queue<T>.Enumerator);
		}

		protected override Queue<T> Complete(Queue<T> intermediateCollection)
		{
			return null;
		}
	}
}
