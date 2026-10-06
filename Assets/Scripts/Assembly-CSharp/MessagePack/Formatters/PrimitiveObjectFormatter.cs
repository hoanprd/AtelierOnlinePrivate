using System;
using System.Collections.Generic;
using System.Reflection;

namespace MessagePack.Formatters
{
	public sealed class PrimitiveObjectFormatter : IMessagePackFormatter<object>, IMessagePackFormatter
	{
		public static readonly IMessagePackFormatter<object> Instance;

		private static readonly Dictionary<Type, int> typeToJumpCode;

		private PrimitiveObjectFormatter()
		{
		}

		public static bool IsSupportedType(Type type, TypeInfo typeInfo, object value)
		{
			return false;
		}

		public int Serialize(ref byte[] bytes, int offset, object value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public object Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
