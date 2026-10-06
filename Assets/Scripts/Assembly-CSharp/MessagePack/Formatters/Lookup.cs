using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MessagePack.Formatters
{
	internal class Lookup<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable, IEnumerable<IGrouping<TKey, TElement>>
	{
		private readonly Dictionary<TKey, IGrouping<TKey, TElement>> groupings;

		// C# has no syntax for parameterized property 'Item'.
		public IEnumerable<TElement> get_Item(TKey key)
		{
			return null;
		}

		public int Count
		{
			get
			{
				return 0;
			}
		}

		public Lookup(Dictionary<TKey, IGrouping<TKey, TElement>> groupings)
		{
		}

		public bool Contains(TKey key)
		{
			return false;
		}

		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
