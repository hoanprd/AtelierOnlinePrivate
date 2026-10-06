using System.Runtime.InteropServices;

namespace MessagePack
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	internal struct Float64Bits
	{
		[FieldOffset(0)]
		public readonly double Value;

		[FieldOffset(0)]
		public readonly byte Byte0;

		[FieldOffset(1)]
		public readonly byte Byte1;

		[FieldOffset(2)]
		public readonly byte Byte2;

		[FieldOffset(3)]
		public readonly byte Byte3;

		[FieldOffset(4)]
		public readonly byte Byte4;

		[FieldOffset(5)]
		public readonly byte Byte5;

		[FieldOffset(6)]
		public readonly byte Byte6;

		[FieldOffset(7)]
		public readonly byte Byte7;

		public Float64Bits(double value)
		{
			Value = 0.0;
			Byte0 = 0;
			Byte1 = 0;
			Byte2 = 0;
			Byte3 = 0;
			Byte4 = 0;
			Byte5 = 0;
			Byte6 = 0;
			Byte7 = 0;
		}

		public Float64Bits(byte[] bigEndianBytes, int offset)
		{
			Value = 0.0;
			Byte0 = 0;
			Byte1 = 0;
			Byte2 = 0;
			Byte3 = 0;
			Byte4 = 0;
			Byte5 = 0;
			Byte6 = 0;
			Byte7 = 0;
		}
	}
}
