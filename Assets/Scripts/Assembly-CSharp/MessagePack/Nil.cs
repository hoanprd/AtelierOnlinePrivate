using System;
using System.Runtime.InteropServices;

namespace MessagePack
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct Nil : IEquatable<Nil>
	{
		public static readonly Nil Default;

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Nil other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
