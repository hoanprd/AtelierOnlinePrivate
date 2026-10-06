using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MessagePack.Formatters
{
	internal class Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable, IEnumerable<TElement>
	{
		private readonly TKey key;

		private readonly IEnumerable<TElement> elements;

		public TKey Key
		{
			get
			{
				return default(TKey);
			}
		}

		public Grouping(TKey key, IEnumerable<TElement> elements)
		{
		}

		public IEnumerator<TElement> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
