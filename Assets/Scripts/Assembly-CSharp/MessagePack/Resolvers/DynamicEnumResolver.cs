using System;
using System.Reflection;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace MessagePack.Resolvers
{
	public sealed class DynamicEnumResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly DynamicEnumResolver Instance;

		private const string ModuleName = "MessagePack.Resolvers.DynamicEnumResolver";

		private static readonly DynamicAssembly assembly;

		private static int nameSequence;

		private DynamicEnumResolver()
		{
		}

		static DynamicEnumResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}

		private static TypeInfo BuildType(Type enumType)
		{
			return null;
		}
	}
}
