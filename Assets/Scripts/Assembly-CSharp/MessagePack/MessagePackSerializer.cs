using System;
using System.IO;
using System.Text;

namespace MessagePack
{
	public static class MessagePackSerializer
	{
		private static IFormatterResolver defaultResolver;

		public static IFormatterResolver DefaultResolver
		{
			get
			{
				return null;
			}
		}

		public static bool IsInitialized
		{
			get
			{
				return false;
			}
		}

		public static void SetDefaultResolver(IFormatterResolver resolver)
		{
		}

		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		public static byte[] Serialize<T>(T obj, IFormatterResolver resolver)
		{
			return null;
		}

		public static ArraySegment<byte> SerializeUnsafe<T>(T obj)
		{
			return default(ArraySegment<byte>);
		}

		public static ArraySegment<byte> SerializeUnsafe<T>(T obj, IFormatterResolver resolver)
		{
			return default(ArraySegment<byte>);
		}

		public static void Serialize<T>(Stream stream, T obj)
		{
		}

		public static void Serialize<T>(Stream stream, T obj, IFormatterResolver resolver)
		{
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

		internal static ArraySegment<byte> FromJsonUnsafe(TextReader reader)
		{
			return default(ArraySegment<byte>);
		}

		private static uint FromJsonCore(TinyJsonReader jr, ref byte[] binary, ref int offset)
		{
			return 0u;
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
