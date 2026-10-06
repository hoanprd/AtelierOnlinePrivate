using System.Runtime.InteropServices;

namespace MessagePack
{
	[StructLayout((LayoutKind)0, Size = 8)]
	public struct ExtensionHeader
	{
		public sbyte TypeCode { get; private set; }

		public uint Length { get; private set; }

		public ExtensionHeader(sbyte typeCode, uint length)
		{
			TypeCode = 0;
			Length = 0u;
		}
	}
}
