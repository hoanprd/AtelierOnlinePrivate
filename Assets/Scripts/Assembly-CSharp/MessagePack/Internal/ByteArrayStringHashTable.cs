using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MessagePack.Internal
{
	public class ByteArrayStringHashTable : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[StructLayout((LayoutKind)0, Size = 16)]
		private struct Entry
		{
			public byte[] Key;

			public int Value;

			public override string ToString()
			{
				return null;
			}
		}

		private readonly Entry[][] buckets;

		private readonly ulong indexFor;

		public ByteArrayStringHashTable(int capacity)
		{
		}

		public ByteArrayStringHashTable(int capacity, float loadFactor)
		{
		}

		public void Add(string key, int value)
		{
		}

		public void Add(byte[] key, int value)
		{
		}

		private bool TryAddInternal(byte[] key, int value)
		{
			return false;
		}

		public bool TryGetValue(ArraySegment<byte> key, out int value)
		{
			value = default(int);
			return false;
		}

		private static ulong ByteArrayGetHashCode(byte[] x, int offset, int count)
		{
			return 0uL;
		}

		private static int CalculateCapacity(int collectionSize, float loadFactor)
		{
			return 0;
		}

		[DebuggerHidden]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
