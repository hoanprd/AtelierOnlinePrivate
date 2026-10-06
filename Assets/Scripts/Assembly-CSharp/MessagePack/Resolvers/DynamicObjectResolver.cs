using MessagePack.Formatters;
using MessagePack.Internal;

namespace MessagePack.Resolvers
{
	public sealed class DynamicObjectResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly DynamicObjectResolver Instance;

		private const string ModuleName = "MessagePack.Resolvers.DynamicObjectResolver";

		internal static readonly DynamicAssembly assembly;

		private DynamicObjectResolver()
		{
		}

		static DynamicObjectResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
