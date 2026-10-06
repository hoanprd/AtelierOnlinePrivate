using MessagePack.Formatters;

namespace MessagePack.Resolvers
{
	public sealed class DynamicContractlessObjectResolverAllowPrivate : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly DynamicContractlessObjectResolverAllowPrivate Instance;

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
