using System;
using System.Collections.Generic;

namespace MessagePack.Internal
{
	public class RuntimeTypeHandleEqualityComparer : IEqualityComparer<RuntimeTypeHandle>
	{
		public static IEqualityComparer<RuntimeTypeHandle> Default;

		private RuntimeTypeHandleEqualityComparer()
		{
		}

		public bool Equals(RuntimeTypeHandle x, RuntimeTypeHandle y)
		{
			return false;
		}

		public int GetHashCode(RuntimeTypeHandle obj)
		{
			return 0;
		}
	}
}
