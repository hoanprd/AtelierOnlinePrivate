using MessagePack.Formatters;

namespace MessagePack.Resolvers
{
	public sealed class DynamicObjectResolverAllowPrivate : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly DynamicObjectResolverAllowPrivate Instance;

		private DynamicObjectResolverAllowPrivate()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
