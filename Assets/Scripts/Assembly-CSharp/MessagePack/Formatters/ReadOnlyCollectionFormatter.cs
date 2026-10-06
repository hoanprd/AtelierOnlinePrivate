using System.Collections.ObjectModel;

namespace MessagePack.Formatters
{
	public sealed class ReadOnlyCollectionFormatter<T> : CollectionFormatterBase<T, T[], ReadOnlyCollection<T>>
	{
		protected override void Add(T[] collection, int index, T value)
		{
		}

		protected override ReadOnlyCollection<T> Complete(T[] intermediateCollection)
		{
			return null;
		}

		protected override T[] Create(int count)
		{
			return null;
		}
	}
}
