using System;
using System.IO;
using MessagePack.Decoders;

namespace MessagePack
{
	public static class MessagePackBinary
	{
		private static class StreamDecodeMemoryPool
		{
			[ThreadStatic]
			private static byte[] buffer;

			public static byte[] GetBuffer()
			{
				return null;
			}
		}

		private const int MaxSize = 256;

		private const int ArrayMaxSize = 2147483591;

		private static readonly IMapHeaderDecoder[] mapHeaderDecoders;

		private static readonly IArrayHeaderDecoder[] arrayHeaderDecoders;

		private static readonly IBooleanDecoder[] booleanDecoders;

		private static readonly IByteDecoder[] byteDecoders;

		private static readonly IBytesDecoder[] bytesDecoders;

		private static readonly IBytesSegmentDecoder[] bytesSegmentDecoders;

		private static readonly ISByteDecoder[] sbyteDecoders;

		private static readonly ISingleDecoder[] singleDecoders;

		private static readonly IDoubleDecoder[] doubleDecoders;

		private static readonly IInt16Decoder[] int16Decoders;

		private static readonly IInt32Decoder[] int32Decoders;

		private static readonly IInt64Decoder[] int64Decoders;

		private static readonly IUInt16Decoder[] uint16Decoders;

		private static readonly IUInt32Decoder[] uint32Decoders;

		private static readonly IUInt64Decoder[] uint64Decoders;

		private static readonly IStringDecoder[] stringDecoders;

		private static readonly IStringSegmentDecoder[] stringSegmentDecoders;

		private static readonly IExtDecoder[] extDecoders;

		private static readonly IExtHeaderDecoder[] extHeaderDecoders;

		private static readonly IDateTimeDecoder[] dateTimeDecoders;

		private static readonly IReadNextDecoder[] readNextDecoders;

		static MessagePackBinary()
		{
		}

		public static void EnsureCapacity(ref byte[] bytes, int offset, int appendLength)
		{
		}

		public static void FastResize(ref byte[] array, int newSize)
		{
		}

		public static byte[] FastCloneWithResize(byte[] array, int newSize)
		{
			return null;
		}

		public static MessagePackType GetMessagePackType(byte[] bytes, int offset)
		{
			return MessagePackType.Unknown;
		}

		public static int ReadNext(byte[] bytes, int offset)
		{
			return 0;
		}

		public static int ReadNextBlock(byte[] bytes, int offset)
		{
			return 0;
		}

		public static int WriteNil(ref byte[] bytes, int offset)
		{
			return 0;
		}

		public static Nil ReadNil(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(Nil);
		}

		public static bool IsNil(byte[] bytes, int offset)
		{
			return false;
		}

		public static int WriteRaw(ref byte[] bytes, int offset, byte[] rawMessagePackBlock)
		{
			return 0;
		}

		public static int WriteFixedMapHeaderUnsafe(ref byte[] bytes, int offset, int count)
		{
			return 0;
		}

		public static int WriteMapHeader(ref byte[] bytes, int offset, int count)
		{
			return 0;
		}

		public static int WriteMapHeader(ref byte[] bytes, int offset, uint count)
		{
			return 0;
		}

		public static int WriteMapHeaderForceMap32Block(ref byte[] bytes, int offset, uint count)
		{
			return 0;
		}

		public static int ReadMapHeader(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}

		public static uint ReadMapHeaderRaw(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}

		public static int GetArrayHeaderLength(int count)
		{
			return 0;
		}

		public static int WriteFixedArrayHeaderUnsafe(ref byte[] bytes, int offset, int count)
		{
			return 0;
		}

		public static int WriteArrayHeader(ref byte[] bytes, int offset, int count)
		{
			return 0;
		}

		public static int WriteArrayHeader(ref byte[] bytes, int offset, uint count)
		{
			return 0;
		}

		public static int WriteArrayHeaderForceArray32Block(ref byte[] bytes, int offset, uint count)
		{
			return 0;
		}

		public static int ReadArrayHeader(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}

		public static uint ReadArrayHeaderRaw(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}

		public static int WriteBoolean(ref byte[] bytes, int offset, bool value)
		{
			return 0;
		}

		public static bool ReadBoolean(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return false;
		}

		public static int WriteByte(ref byte[] bytes, int offset, byte value)
		{
			return 0;
		}

		public static int WriteByteForceByteBlock(ref byte[] bytes, int offset, byte value)
		{
			return 0;
		}

		public static byte ReadByte(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}

		public static int WriteBytes(ref byte[] bytes, int offset, byte[] value)
		{
			return 0;
		}

		public static int WriteBytes(ref byte[] dest, int dstOffset, byte[] src, int srcOffset, int count)
		{
			return 0;
		}

		public static byte[] ReadBytes(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}

		public static ArraySegment<byte> ReadBytesSegment(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}

		public static int WriteSByte(ref byte[] bytes, int offset, sbyte value)
		{
			return 0;
		}

		public static int WriteSByteForceSByteBlock(ref byte[] bytes, int offset, sbyte value)
		{
			return 0;
		}

		public static sbyte ReadSByte(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}

		public static int WriteSingle(ref byte[] bytes, int offset, float value)
		{
			return 0;
		}

		public static float ReadSingle(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0f;
		}

		public static int WriteDouble(ref byte[] bytes, int offset, double value)
		{
			return 0;
		}

		public static double ReadDouble(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0.0;
		}

		public static int WriteInt16(ref byte[] bytes, int offset, short value)
		{
			return 0;
		}

		public static int WriteInt16ForceInt16Block(ref byte[] bytes, int offset, short value)
		{
			return 0;
		}

		public static short ReadInt16(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}

		public static int WritePositiveFixedIntUnsafe(ref byte[] bytes, int offset, int value)
		{
			return 0;
		}

		public static int WriteInt32(ref byte[] bytes, int offset, int value)
		{
			return 0;
		}

		public static int WriteInt32ForceInt32Block(ref byte[] bytes, int offset, int value)
		{
			return 0;
		}

		public static int ReadInt32(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}

		public static int WriteInt64(ref byte[] bytes, int offset, long value)
		{
			return 0;
		}

		public static int WriteInt64ForceInt64Block(ref byte[] bytes, int offset, long value)
		{
			return 0;
		}

		public static long ReadInt64(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0L;
		}

		public static int WriteUInt16(ref byte[] bytes, int offset, ushort value)
		{
			return 0;
		}

		public static int WriteUInt16ForceUInt16Block(ref byte[] bytes, int offset, ushort value)
		{
			return 0;
		}

		public static ushort ReadUInt16(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0;
		}

		public static int WriteUInt32(ref byte[] bytes, int offset, uint value)
		{
			return 0;
		}

		public static int WriteUInt32ForceUInt32Block(ref byte[] bytes, int offset, uint value)
		{
			return 0;
		}

		public static uint ReadUInt32(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0u;
		}

		public static int WriteUInt64(ref byte[] bytes, int offset, ulong value)
		{
			return 0;
		}

		public static int WriteUInt64ForceUInt64Block(ref byte[] bytes, int offset, ulong value)
		{
			return 0;
		}

		public static ulong ReadUInt64(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return 0uL;
		}

		public static int WriteChar(ref byte[] bytes, int offset, char value)
		{
			return 0;
		}

		public static char ReadChar(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return '\0';
		}

		public static int WriteFixedStringUnsafe(ref byte[] bytes, int offset, string value, int byteCount)
		{
			return 0;
		}

		public static int WriteStringUnsafe(ref byte[] bytes, int offset, string value, int byteCount)
		{
			return 0;
		}

		public static int WriteStringBytes(ref byte[] bytes, int offset, byte[] utf8stringBytes)
		{
			return 0;
		}

		public static byte[] GetEncodedStringBytes(string value)
		{
			return null;
		}

		public static int WriteString(ref byte[] bytes, int offset, string value)
		{
			return 0;
		}

		public static int WriteStringForceStr32Block(ref byte[] bytes, int offset, string value)
		{
			return 0;
		}

		public static string ReadString(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return null;
		}

		public static ArraySegment<byte> ReadStringSegment(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ArraySegment<byte>);
		}

		public static int WriteExtensionFormatHeader(ref byte[] bytes, int offset, sbyte typeCode, int dataLength)
		{
			return 0;
		}

		public static int WriteExtensionFormatHeaderForceExt32Block(ref byte[] bytes, int offset, sbyte typeCode, int dataLength)
		{
			return 0;
		}

		public static int WriteExtensionFormat(ref byte[] bytes, int offset, sbyte typeCode, byte[] data)
		{
			return 0;
		}

		public static ExtensionResult ReadExtensionFormat(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionResult);
		}

		public static ExtensionHeader ReadExtensionFormatHeader(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(ExtensionHeader);
		}

		public static int GetExtensionFormatHeaderLength(int dataLength)
		{
			return 0;
		}

		public static int WriteDateTime(ref byte[] bytes, int offset, DateTime dateTime)
		{
			return 0;
		}

		public static DateTime ReadDateTime(byte[] bytes, int offset, out int readSize)
		{
			readSize = default(int);
			return default(DateTime);
		}

		private static byte[] ReadMessageBlockFromStreamUnsafe(Stream stream)
		{
			return null;
		}

		public static byte[] ReadMessageBlockFromStreamUnsafe(Stream stream, bool readOnlySingleMessage, out int readSize)
		{
			readSize = default(int);
			return null;
		}

		private static int ReadMessageBlockFromStreamCore(Stream stream, ref byte[] bytes, int offset, bool readOnlySingleMessage)
		{
			return 0;
		}

		private static void ReadFully(Stream stream, byte[] bytes, int offset, int readSize)
		{
		}

		public static int ReadNext(Stream stream)
		{
			return 0;
		}

		public static int ReadNextBlock(Stream stream)
		{
			return 0;
		}

		public static int WriteNil(Stream stream)
		{
			return 0;
		}

		public static Nil ReadNil(Stream stream)
		{
			return default(Nil);
		}

		public static bool IsNil(Stream stream)
		{
			return false;
		}

		public static int WriteFixedMapHeaderUnsafe(Stream stream, int count)
		{
			return 0;
		}

		public static int WriteMapHeader(Stream stream, int count)
		{
			return 0;
		}

		public static int WriteMapHeader(Stream stream, uint count)
		{
			return 0;
		}

		public static int WriteMapHeaderForceMap32Block(Stream stream, uint count)
		{
			return 0;
		}

		public static int ReadMapHeader(Stream stream)
		{
			return 0;
		}

		public static uint ReadMapHeaderRaw(Stream stream)
		{
			return 0u;
		}

		public static int WriteFixedArrayHeaderUnsafe(Stream stream, int count)
		{
			return 0;
		}

		public static int WriteArrayHeader(Stream stream, int count)
		{
			return 0;
		}

		public static int WriteArrayHeader(Stream stream, uint count)
		{
			return 0;
		}

		public static int WriteArrayHeaderForceArray32Block(Stream stream, uint count)
		{
			return 0;
		}

		public static int ReadArrayHeader(Stream stream)
		{
			return 0;
		}

		public static uint ReadArrayHeaderRaw(Stream stream)
		{
			return 0u;
		}

		public static int WriteBoolean(Stream stream, bool value)
		{
			return 0;
		}

		public static bool ReadBoolean(Stream stream)
		{
			return false;
		}

		public static int WriteByte(Stream stream, byte value)
		{
			return 0;
		}

		public static int WriteByteForceByteBlock(Stream stream, byte value)
		{
			return 0;
		}

		public static byte ReadByte(Stream stream)
		{
			return 0;
		}

		public static int WriteBytes(Stream stream, byte[] value)
		{
			return 0;
		}

		public static int WriteBytes(Stream stream, byte[] src, int srcOffset, int count)
		{
			return 0;
		}

		public static byte[] ReadBytes(Stream stream)
		{
			return null;
		}

		public static int WriteSByte(Stream stream, sbyte value)
		{
			return 0;
		}

		public static int WriteSByteForceSByteBlock(Stream stream, sbyte value)
		{
			return 0;
		}

		public static sbyte ReadSByte(Stream stream)
		{
			return 0;
		}

		public static int WriteSingle(Stream stream, float value)
		{
			return 0;
		}

		public static float ReadSingle(Stream stream)
		{
			return 0f;
		}

		public static int WriteDouble(Stream stream, double value)
		{
			return 0;
		}

		public static double ReadDouble(Stream stream)
		{
			return 0.0;
		}

		public static int WriteInt16(Stream stream, short value)
		{
			return 0;
		}

		public static int WriteInt16ForceInt16Block(Stream stream, short value)
		{
			return 0;
		}

		public static short ReadInt16(Stream stream)
		{
			return 0;
		}

		public static int WritePositiveFixedIntUnsafe(Stream stream, int value)
		{
			return 0;
		}

		public static int WriteInt32(Stream stream, int value)
		{
			return 0;
		}

		public static int WriteInt32ForceInt32Block(Stream stream, int value)
		{
			return 0;
		}

		public static int ReadInt32(Stream stream)
		{
			return 0;
		}

		public static int WriteInt64(Stream stream, long value)
		{
			return 0;
		}

		public static int WriteInt64ForceInt64Block(Stream stream, long value)
		{
			return 0;
		}

		public static long ReadInt64(Stream stream)
		{
			return 0L;
		}

		public static int WriteUInt16(Stream stream, ushort value)
		{
			return 0;
		}

		public static int WriteUInt16ForceUInt16Block(Stream stream, ushort value)
		{
			return 0;
		}

		public static ushort ReadUInt16(Stream stream)
		{
			return 0;
		}

		public static int WriteUInt32(Stream stream, uint value)
		{
			return 0;
		}

		public static int WriteUInt32ForceUInt32Block(Stream stream, uint value)
		{
			return 0;
		}

		public static uint ReadUInt32(Stream stream)
		{
			return 0u;
		}

		public static int WriteUInt64(Stream stream, ulong value)
		{
			return 0;
		}

		public static int WriteUInt64ForceUInt64Block(Stream stream, ulong value)
		{
			return 0;
		}

		public static ulong ReadUInt64(Stream stream)
		{
			return 0uL;
		}

		public static int WriteChar(Stream stream, char value)
		{
			return 0;
		}

		public static char ReadChar(Stream stream)
		{
			return '\0';
		}

		public static int WriteFixedStringUnsafe(Stream stream, string value, int byteCount)
		{
			return 0;
		}

		public static int WriteStringUnsafe(Stream stream, string value, int byteCount)
		{
			return 0;
		}

		public static int WriteStringBytes(Stream stream, byte[] utf8stringBytes)
		{
			return 0;
		}

		public static int WriteString(Stream stream, string value)
		{
			return 0;
		}

		public static int WriteStringForceStr32Block(Stream stream, string value)
		{
			return 0;
		}

		public static string ReadString(Stream stream)
		{
			return null;
		}

		public static int WriteExtensionFormatHeader(Stream stream, sbyte typeCode, int dataLength)
		{
			return 0;
		}

		public static int WriteExtensionFormatHeaderForceExt32Block(Stream stream, sbyte typeCode, int dataLength)
		{
			return 0;
		}

		public static int WriteExtensionFormat(Stream stream, sbyte typeCode, byte[] data)
		{
			return 0;
		}

		public static ExtensionResult ReadExtensionFormat(Stream stream)
		{
			return default(ExtensionResult);
		}

		public static ExtensionHeader ReadExtensionFormatHeader(Stream stream)
		{
			return default(ExtensionHeader);
		}

		public static int WriteDateTime(Stream stream, DateTime dateTime)
		{
			return 0;
		}

		public static DateTime ReadDateTime(Stream stream)
		{
			return default(DateTime);
		}
	}
}
