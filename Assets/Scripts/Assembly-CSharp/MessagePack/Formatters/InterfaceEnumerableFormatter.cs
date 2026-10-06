using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public sealed class InterfaceEnumerableFormatter<T> : CollectionFormatterBase<T, T[], IEnumerable<T>>
	{
		protected override void Add(T[] collection, int index, T value)
		{
		}

		protected override T[] Create(int count)
		{
			return null;
		}

		protected override IEnumerable<T> Complete(T[] intermediateCollection)
		{
			return null;
		}
	}
}
