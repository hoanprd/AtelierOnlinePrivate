using MessagePack.Formatters;

namespace MessagePack.Internal
{
	internal sealed class StandardResolverAllowPrivateCore : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly IFormatterResolver Instance;

		private static readonly IFormatterResolver[] resolvers;

		private StandardResolverAllowPrivateCore()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
