using System.Runtime.InteropServices;

namespace MessagePack
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	internal struct Float32Bits
	{
		[FieldOffset(0)]
		public readonly float Value;

		[FieldOffset(0)]
		public readonly byte Byte0;

		[FieldOffset(1)]
		public readonly byte Byte1;

		[FieldOffset(2)]
		public readonly byte Byte2;

		[FieldOffset(3)]
		public readonly byte Byte3;

		public Float32Bits(float value)
		{
			Value = 0f;
			Byte0 = 0;
			Byte1 = 0;
			Byte2 = 0;
			Byte3 = 0;
		}

		public Float32Bits(byte[] bigEndianBytes, int offset)
		{
			Value = 0f;
			Byte0 = 0;
			Byte1 = 0;
			Byte2 = 0;
			Byte3 = 0;
		}
	}
}
