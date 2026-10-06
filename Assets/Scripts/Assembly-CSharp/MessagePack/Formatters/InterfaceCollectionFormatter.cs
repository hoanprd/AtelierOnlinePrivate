using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class InterfaceCollectionFormatter<T> : CollectionFormatterBase<T, T[], ICollection<T>>
	{
		protected override void Add(T[] collection, int index, T value)
		{
		}

		protected override T[] Create(int count)
		{
			return null;
		}

		protected override ICollection<T> Complete(T[] intermediateCollection)
		{
			return null;
		}
	}
}
