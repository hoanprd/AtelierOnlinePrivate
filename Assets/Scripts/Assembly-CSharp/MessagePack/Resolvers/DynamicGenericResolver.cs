using MessagePack.Formatters;

namespace MessagePack.Resolvers
{
	public sealed class DynamicGenericResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly IFormatterResolver Instance;

		private DynamicGenericResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
