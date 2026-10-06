using System.Runtime.InteropServices;

namespace MessagePack
{
	[StructLayout((LayoutKind)0, Size = 16)]
	public struct ExtensionResult
	{
		public sbyte TypeCode { get; private set; }

		public byte[] Data { get; private set; }

		public ExtensionResult(sbyte typeCode, byte[] data)
		{
			TypeCode = 0;
			Data = null;
		}
	}
}
