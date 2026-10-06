using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class InterfaceListFormatter<T> : CollectionFormatterBase<T, T[], IList<T>>
	{
		protected override void Add(T[] collection, int index, T value)
		{
		}

		protected override T[] Create(int count)
		{
			return null;
		}

		protected override IList<T> Complete(T[] intermediateCollection)
		{
			return null;
		}
	}
}
