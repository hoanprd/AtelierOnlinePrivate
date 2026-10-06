using System;
using System.IO;
using System.Text;

namespace MessagePack
{
	public static class LZ4MessagePackSerializer
	{
		public const sbyte ExtensionTypeCode = 99;

		public const int NotCompressionSize = 64;

		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		public static byte[] Serialize<T>(T obj, IFormatterResolver resolver)
		{
			return null;
		}

		public static void Serialize<T>(Stream stream, T obj)
		{
		}

		public static void Serialize<T>(Stream stream, T obj, IFormatterResolver resolver)
		{
		}

		public static int SerializeToBlock<T>(ref byte[] bytes, int offset, T obj, IFormatterResolver resolver)
		{
			return 0;
		}

		public static byte[] ToLZ4Binary(ArraySegment<byte> messagePackBinary)
		{
			return null;
		}

		private static ArraySegment<byte> SerializeCore<T>(T obj, IFormatterResolver resolver)
		{
			return default(ArraySegment<byte>);
		}

		private static ArraySegment<byte> ToLZ4BinaryCore(ArraySegment<byte> serializedData)
		{
			return default(ArraySegment<byte>);
		}

		public static T Deserialize<T>(byte[] bytes)
		{
			return default(T);
		}

		public static T Deserialize<T>(byte[] bytes, IFormatterResolver resolver)
		{
			return default(T);
		}

		public static T Deserialize<T>(ArraySegment<byte> bytes)
		{
			return default(T);
		}

		public static T Deserialize<T>(ArraySegment<byte> bytes, IFormatterResolver resolver)
		{
			return default(T);
		}

		public static T Deserialize<T>(Stream stream)
		{
			return default(T);
		}

		public static T Deserialize<T>(Stream stream, IFormatterResolver resolver)
		{
			return default(T);
		}

		public static T Deserialize<T>(Stream stream, bool readStrict)
		{
			return default(T);
		}

		public static T Deserialize<T>(Stream stream, IFormatterResolver resolver, bool readStrict)
		{
			return default(T);
		}

		public static byte[] Decode(Stream stream, bool readStrict = false)
		{
			return null;
		}

		public static byte[] Decode(byte[] bytes)
		{
			return null;
		}

		public static byte[] Decode(ArraySegment<byte> bytes)
		{
			return null;
		}

		public static byte[] DecodeUnsafe(byte[] bytes)
		{
			return null;
		}

		public static byte[] DecodeUnsafe(ArraySegment<byte> bytes)
		{
			return null;
		}

		private static T DeserializeCore<T>(ArraySegment<byte> bytes, IFormatterResolver resolver)
		{
			return default(T);
		}

		private static int FillFromStream(Stream input, ref byte[] buffer)
		{
			return 0;
		}

		public static string ToJson<T>(T obj)
		{
			return null;
		}

		public static string ToJson<T>(T obj, IFormatterResolver resolver)
		{
			return null;
		}

		public static string ToJson(byte[] bytes)
		{
			return null;
		}

		public static byte[] FromJson(string str)
		{
			return null;
		}

		public static byte[] FromJson(TextReader reader)
		{
			return null;
		}

		private static int ToJsonCore(byte[] bytes, int offset, StringBuilder builder)
		{
			return 0;
		}

		private static void WriteJsonString(string value, StringBuilder builder)
		{
		}
	}
}
