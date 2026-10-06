using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class StackFormatter<T> : CollectionFormatterBase<T, T[], Stack<T>.Enumerator, Stack<T>>
	{
		protected override int? GetCount(Stack<T> sequence)
		{
			return null;
		}

		protected override void Add(T[] collection, int index, T value)
		{
		}

		protected override T[] Create(int count)
		{
			return null;
		}

		protected override Stack<T>.Enumerator GetSourceEnumerator(Stack<T> source)
		{
			return default(Stack<T>.Enumerator);
		}

		protected override Stack<T> Complete(T[] intermediateCollection)
		{
			return null;
		}
	}
}
