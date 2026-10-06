using System;

namespace MessagePack.LZ4
{
	public static class LZ4Codec
	{
		internal static class HashTablePool
		{
			[ThreadStatic]
			private static ushort[] ushortPool;

			[ThreadStatic]
			private static uint[] uintPool;

			[ThreadStatic]
			private static int[] intPool;

			public static ushort[] GetUShortHashTablePool()
			{
				return null;
			}

			public static uint[] GetUIntHashTablePool()
			{
				return null;
			}

			public static int[] GetIntHashTablePool()
			{
				return null;
			}
		}

		private const int MEMORY_USAGE = 12;

		private const int NOTCOMPRESSIBLE_DETECTIONLEVEL = 6;

		private const int MINMATCH = 4;

		private const int SKIPSTRENGTH = 6;

		private const int COPYLENGTH = 8;

		private const int LASTLITERALS = 5;

		private const int MFLIMIT = 12;

		private const int MINLENGTH = 13;

		private const int MAXD_LOG = 16;

		private const int MAXD = 65536;

		private const int MAXD_MASK = 65535;

		private const int MAX_DISTANCE = 65535;

		private const int ML_BITS = 4;

		private const int ML_MASK = 15;

		private const int RUN_BITS = 4;

		private const int RUN_MASK = 15;

		private const int STEPSIZE_64 = 8;

		private const int STEPSIZE_32 = 4;

		private const int LZ4_64KLIMIT = 65547;

		private const int HASH_LOG = 10;

		private const int HASH_TABLESIZE = 1024;

		private const int HASH_ADJUST = 22;

		private const int HASH64K_LOG = 11;

		private const int HASH64K_TABLESIZE = 2048;

		private const int HASH64K_ADJUST = 21;

		private const int HASHHC_LOG = 15;

		private const int HASHHC_TABLESIZE = 32768;

		private const int HASHHC_ADJUST = 17;

		private static readonly int[] DECODER_TABLE_32;

		private static readonly int[] DECODER_TABLE_64;

		private static readonly int[] DEBRUIJN_TABLE_32;

		private static readonly int[] DEBRUIJN_TABLE_64;

		private const int MAX_NB_ATTEMPTS = 256;

		private const int OPTIMAL_ML = 18;

		private const int BLOCK_COPY_LIMIT = 16;

		public static int MaximumOutputLength(int inputLength)
		{
			return 0;
		}

		internal static void CheckArguments(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
		}

		public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		private static void Assert(bool condition, string errorMessage)
		{
		}

		internal static void Poke2(byte[] buffer, int offset, ushort value)
		{
		}

		internal static ushort Peek2(byte[] buffer, int offset)
		{
			return 0;
		}

		internal static uint Peek4(byte[] buffer, int offset)
		{
			return 0u;
		}

		private static uint Xor4(byte[] buffer, int offset1, int offset2)
		{
			return 0u;
		}

		private static ulong Xor8(byte[] buffer, int offset1, int offset2)
		{
			return 0uL;
		}

		private static bool Equal2(byte[] buffer, int offset1, int offset2)
		{
			return false;
		}

		private static bool Equal4(byte[] buffer, int offset1, int offset2)
		{
			return false;
		}

		private static void Copy4(byte[] buf, int src, int dst)
		{
		}

		private static void Copy8(byte[] buf, int src, int dst)
		{
		}

		private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len)
		{
		}

		private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end)
		{
			return 0;
		}

		private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end)
		{
			return 0;
		}

		public static int Encode32Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static int Encode64Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static int Decode32Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		public static int Decode64Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
		{
			return 0;
		}

		private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len)
		{
			return 0;
		}

		private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
		{
			return 0;
		}

		private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len)
		{
			return 0;
		}
	}
}
